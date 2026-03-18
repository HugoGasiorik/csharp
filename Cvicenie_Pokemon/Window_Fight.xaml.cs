using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Cvicenie_Pokemon
{
    public partial class Window_Fight : Window
    {
        public Hero MyActualHero { get; set; }
        public Enemy Enemy { get; set; }

        private int _initHeroHealth, _initHeroEnergy, _initEnemyHealth;
        private int _strongAttackCooldown = 0;
        private const int STRONG_COOLDOWN_TURNS = 3;
        private Random _rng = new Random();

        private const int COST_MEDIUM = 20;
        private const int COST_HEAL = 30;
        private const int COST_STRONG = 50;
        private const int ENERGY_REGEN = 15;
        private const int HEAL_AMOUNT = 30;

        public Window_Fight(Hero hero, Enemy enemy)
        {
            InitializeComponent();
            MyActualHero = hero;
            Enemy = enemy;

            _initHeroHealth = hero.Health;
            _initHeroEnergy = hero.Energy;
            _initEnemyHealth = enemy.Health;

            // Nastaví obrázok nepriateľa podľa absolútnej cesty
            Image_Enemy.Source = new BitmapImage(new Uri(enemy.ImagePath, UriKind.Absolute));
            Label_EnemyName.Content = enemy.Name;

            RefreshUI();
        }

        private void HeroAttackEnemy(int multiplier, string attackName)
        {
            int baseDamage = MyActualHero.Damage * multiplier;
            bool isCrit = _rng.Next(100) < 25;
            bool isMiss = _rng.Next(100) < 20;

            if (isMiss)
            {
                Label_Log.Content = $"{attackName}: MISS! Útok sa nepodaril.";
                return;
            }

            if (isCrit) baseDamage = (int)(baseDamage * 1.5);

            Enemy.Health -= baseDamage;
            if (Enemy.Health < 0) Enemy.Health = 0;

            string critText = isCrit ? " CRITICAL HIT! 💥" : "";
            Label_Log.Content = $"{attackName}: -{baseDamage} HP nepriateľovi.{critText}";
        }

        private void EnemyAttackHero()
        {
            if (Enemy.Health <= 0) return;

            bool isMiss = _rng.Next(100) < 15;
            if (isMiss)
            {
                Label_Log.Content += " | Nepriateľ minul!";
                return;
            }

            MyActualHero.Health -= Enemy.Damage;
            if (MyActualHero.Health < 0) MyActualHero.Health = 0;
            Label_Log.Content += $" | Nepriateľ: -{Enemy.Damage} HP tebe.";
        }

        private void RegenEnergy()
        {
            MyActualHero.Energy = Math.Min(MyActualHero.Energy + ENERGY_REGEN, MyActualHero.Energy_Max);
        }

        private void TickCooldown()
        {
            if (_strongAttackCooldown > 0) _strongAttackCooldown--;
        }

        private bool HasEnergy(int cost, string attackName)
        {
            if (MyActualHero.Energy < cost)
            {
                Label_Log.Content = $"Nedostatok energie pre {attackName}! (potrebuješ {cost}E)";
                return false;
            }
            return true;
        }

        private void EndTurn()
        {
            EnemyAttackHero();
            RegenEnergy();
            TickCooldown();
            RefreshUI();
            CheckHealthStatus();
        }

        private void Button_Easy_Click(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(1, "Light Attack");
            EndTurn();
        }

        private void Button_Medium_Click(object sender, RoutedEventArgs e)
        {
            if (!HasEnergy(COST_MEDIUM, "Medium Attack")) return;
            MyActualHero.Energy -= COST_MEDIUM;
            HeroAttackEnemy(2, "Medium Attack");
            EndTurn();
        }

        private void Button_Strong_Click(object sender, RoutedEventArgs e)
        {
            if (_strongAttackCooldown > 0)
            {
                Label_Log.Content = $"Strong Attack je na cooldowne! ({_strongAttackCooldown} kôl zostáva)";
                return;
            }
            if (!HasEnergy(COST_STRONG, "Strong Attack")) return;
            MyActualHero.Energy -= COST_STRONG;
            HeroAttackEnemy(7, "Strong Attack");
            _strongAttackCooldown = STRONG_COOLDOWN_TURNS;
            EndTurn();
        }

        private void Button_Heal_Click(object sender, RoutedEventArgs e)
        {
            if (!HasEnergy(COST_HEAL, "Heal")) return;
            MyActualHero.Energy -= COST_HEAL;
            int healed = Math.Min(HEAL_AMOUNT, MyActualHero.Health_Max - MyActualHero.Health);
            MyActualHero.Health += healed;
            Label_Log.Content = $"Heal: +{healed} HP.";
            EndTurn();
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            MyActualHero.Health = _initHeroHealth;
            MyActualHero.Energy = _initHeroEnergy;
            Enemy.Health = _initEnemyHealth;
            _strongAttackCooldown = 0;
            Label_GameStatus.Content = "";
            Label_Log.Content = "";
            SetButtonsEnabled(true);
            RefreshUI();
        }

        private void RefreshUI()
        {
            ProgressBar_Hero.Value = MyActualHero.Health;
            ProgressBar_Hero.Maximum = MyActualHero.Health_Max;
            ProgressBar_Enemy.Value = Enemy.Health;
            ProgressBar_Enemy.Maximum = Enemy.Health_Max;
            ProgressBar_Energy.Value = MyActualHero.Energy;
            ProgressBar_Energy.Maximum = MyActualHero.Energy_Max;

            Label_Hero_HP.Content = $"{MyActualHero.Health} / {MyActualHero.Health_Max}";
            Label_Enemy_HP.Content = $"{Enemy.Health} / {Enemy.Health_Max}";
            Label_Energy.Content = $"{MyActualHero.Energy} / {MyActualHero.Energy_Max}";

            double heroPercent = (double)MyActualHero.Health / MyActualHero.Health_Max;
            ProgressBar_Hero.Foreground = heroPercent > 0.5 ? Brushes.Green
                                        : heroPercent > 0.25 ? Brushes.Orange
                                        : Brushes.Red;

            double enemyPercent = (double)Enemy.Health / Enemy.Health_Max;
            ProgressBar_Enemy.Foreground = enemyPercent > 0.5 ? Brushes.Green
                                         : enemyPercent > 0.25 ? Brushes.Orange
                                         : Brushes.Red;

            Label_Cooldown.Content = _strongAttackCooldown > 0
                ? $"Cooldown: {_strongAttackCooldown} kôl"
                : "";

            bool fightOver = MyActualHero.Health <= 0 || Enemy.Health <= 0;
            SetButtonsEnabled(!fightOver);
        }

        private void SetButtonsEnabled(bool enabled)
        {
            Button_Easy.IsEnabled = enabled;
            Button_Medium.IsEnabled = enabled;
            Button_Strong.IsEnabled = enabled;
            Button_Heal.IsEnabled = enabled;
        }

        private void CheckHealthStatus()
        {
            if (MyActualHero.Health <= 0 && Enemy.Health <= 0)
                Label_GameStatus.Content = "Draw! 🤝";
            else if (MyActualHero.Health <= 0)
                Label_GameStatus.Content = "Prehral si! 💀";
            else if (Enemy.Health <= 0)
                Label_GameStatus.Content = "Vyhral si! 🏆";
            else
                Label_GameStatus.Content = "";
        }
    }
}