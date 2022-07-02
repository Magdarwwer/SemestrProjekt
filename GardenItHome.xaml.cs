using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SemestrProjekt
{
    /// <summary>
    /// Interaction logic for GardenItHome.xaml
    /// </summary>
    public partial class GardenItHome : Page
    {
        public GardenItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Atlas Plant Report
            AtlasPage atlasPage = new AtlasPage();
            this.NavigationService.Navigate(atlasPage);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            // View MyPlants page
            MyPlants myplantpage = new MyPlants();
            this.NavigationService.Navigate(myplantpage);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            // View watering Report
            Watering wateringPage = new Watering();
            this.NavigationService.Navigate(wateringPage);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            // View Fertilizing page
            Fertilization fertilingPAge = new Fertilization();
            this.NavigationService.Navigate(fertilingPAge);
        }
    }
}

