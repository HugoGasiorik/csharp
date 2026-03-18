using System.Windows;

namespace Cvicenie_Pokemon
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartFight(Enemy enemy)
        {
            Hero hero = new Hero(100, 100, 10, 100);
            Window_Fight fightWindow = new Window_Fight(hero, enemy);
            fightWindow.Show();
            this.Close();
        }

        private void Button_Charmander_Click(object sender, RoutedEventArgs e)
        {
            Enemy charmander = new Enemy("Charmander", 60, 8,
                @"C:\Users\gasiorikh25\source\repos\CsharpHugo\csharp\Cvicenie_Pokemon\Images\Snímka obrazovky 2026-03-18 67.png");
            StartFight(charmander);
        }

        private void Button_Charmeleon_Click(object sender, RoutedEventArgs e)
        {
            Enemy charmeleon = new Enemy("Charmeleon", 100, 15,
                @"C:\Users\gasiorikh25\source\repos\CsharpHugo\csharp\Cvicenie_Pokemon\Images\Snímka obrazovky 2026-03-18 69.png");
            StartFight(charmeleon);
        }

        private void Button_Charizard_Click(object sender, RoutedEventArgs e)
        {
            Enemy charizard = new Enemy("Charizard", 150, 25,
                @"C:\Users\gasiorikh25\source\repos\CsharpHugo\csharp\Cvicenie_Pokemon\Images\Charizard.png");
            StartFight(charizard);
        }
    }
}