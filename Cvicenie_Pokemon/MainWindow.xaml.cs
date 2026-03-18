using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cvicenie_Pokemon;

namespace Cvicenie_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object Textbox_MyValue;

        public MainWindow()
        {
            InitializeComponent();

            Hero myHero = new Hero(100, 100, 10);
            Enemy enemy = new Enemy(200, 20);

         












            Window_Fight window_Fight = new Window_Fight(myHero, enemy);
            window_Fight.Show();

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

           
           

/*
            window_Fight.ShowDialog();

            string myTextBoxValue = Textbox_MyValue.Text;
                  
            string myTextBoxValue = TextBox_MyValue.Text;

            Window_Fight window_Fight = new Window_Fight(myTextBoxValue);
            window_Fight.Show();


            Button myButton = (Button)sender;
            myButton.IsEnabled = false;
            myButton.Content = "Uz bolo stlacene";*/



        }

        private void TextBox_MyValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



