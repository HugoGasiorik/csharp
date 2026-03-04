using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cvicenie_Pokemon
{
    /// <summary>
    /// Interaction logic for Window_Fight.xaml
    /// </summary>
    public partial class Window_Fight : Window
    {
        public Hero MyActualHero { get; set; }
        public Enemy Enemy { get; set; }

        public Window_Fight( Hero hero, Enemy enemy)
        {
            InitializeComponent();
            MyActualHero = hero;
            Enemy = enemy;
            ProgressBar_Hero.Value = hero.Health;
            ProgressBar_Hero.Maximum = hero.Health_Max;

            ProgressBar_Enemy.Value = enemy.Health;
            ProgressBar_Enemy.Maximum = enemy.Health_Max;
        }

        private void EnemyAttackHero()
        {


            MyActualHero.Health -= Enemy.Damage;
            ProgressBar_Hero.Value = MyActualHero.Health;

        }
      private void HeroAttackEnemy(int multiplier)
        {
            Enemy.Health_Max -= MyActualHero.Damage * multiplier;
            ProgressBar_Enemy.Value = Enemy.Health_Max;
        }

   

        private void Button_Easy_Click(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(1);
            EnemyAttackHero();
            ChechHealthStatus();
        }

        private void Button_Medium_Click(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(2);
            EnemyAttackHero();
            ChechHealthStatus();
        }

        private void Button_Masive_Click(object sender, RoutedEventArgs e)
        {
            HeroAttackEnemy(5);
            EnemyAttackHero();
            ChechHealthStatus();
        }
        private void ChechHealthStatus()
        {
            if(MyActualHero.Health <= 0)
            {
                Label_GameStatus.Content = "Loser";
            }
            if(MyActualHero.Health > 0)
            {
                Label_GameStatus.Content = "Winner";
            }
        }
  
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

}
