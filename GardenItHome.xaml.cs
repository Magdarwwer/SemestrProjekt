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
            // View Expense Report
            //GardenReportPage gardenReportPage = new GardenReportPage();
            //this.NavigationService.Navigate(gardenReportPage);

            // View Atlas Plant Report
            AtlasPage atlasPage = new AtlasPage();
            this.NavigationService.Navigate(atlasPage);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            //GardenReportPage gardenReportPage = new GardenReportPage();
            //this.NavigationService.Navigate(gardenReportPage);

            // View Expense Report
            AtlasPage atlasPage = new AtlasPage();
            this.NavigationService.Navigate(atlasPage);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            //GardenReportPage gardenReportPage = new GardenReportPage();
            //this.NavigationService.Navigate(gardenReportPage);

            // View Expense Report
            GardenReportPage expenseReportPage = new GardenReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            //GardenReportPage gardenReportPage = new GardenReportPage();
            //this.NavigationService.Navigate(gardenReportPage);

            // View Expense Report
            GardenReportPage expenseReportPage = new GardenReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }


    }
}

