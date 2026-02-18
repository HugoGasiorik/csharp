using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cvicenie_MinecraftDressUp
{
    
    public partial class MainWindow : Window
    {
        public string ImagePath { get; set; } = "C:\\Users\\gasiorikh25\\Source\\Repos\\csharp\\Cvicenie_MinecraftDressUp\\Images\\minecraft_armour_sheet_by_dragonshadow3_d8ebr67-414w-2x.png";
        List<ArmourPart> Armours_Helm = new List<ArmourPart>();

        public MainWindow()
        {
            InitializeComponent();

            Armours_Helm.Add(new ArmourPart("Plesinka", 0, EArmourType.None, EArmourpartName.Helmet, 28, 29, 100, 90));
            Armours_Helm.Add(new ArmourPart("Helma bronzova", 1, EArmourType.Bronze, EArmourpartName.Helmet, 28, 29, 100, 90));
            Armours_Helm.Add(new ArmourPart("Helma retiazkova", 2, EArmourType.Chain, EArmourpartName.Helmet, 177, 29, 100, 90));
            Armours_Helm.Add(new ArmourPart("Helma zelezna", 5, EArmourType.Iron, EArmourpartName.Helmet, 338, 29, 100, 90));
            Armours_Helm.Add(new ArmourPart("Helma zlata", 10, EArmourType.Gold, EArmourpartName.Helmet, 505, 29, 100, 90));
            Armours_Helm.Add(new ArmourPart("Helma diamantova", 20, EArmourType.Diamond, EArmourpartName.Helmet, 659, 29, 100, 90));
            Combox_HelmPicker.ItemsSource = Armours_Helm;

          


            










        }

     
            

        private void Combox_HelmPicker_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ArmourPart armourPart = Combox_HelmPicker.SelectedItem as ArmourPart;
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
            bitmap.EndInit();
            bitmap.Freeze();

            var cropped = new CroppedBitmap(bitmap, new Int32Rect(armourPart.XLeft, armourPart.YTop, armourPart.Width, armourPart.Height));
            cropped.Freeze();

            Image_HelmetPlaceHolder.Source = cropped;
            Image_HelmetPlaceHolder.Visibility = Visibility.Visible;
            Label_ActualArmour.Content = armourPart.ArmourPower;

        }
    }
}   
