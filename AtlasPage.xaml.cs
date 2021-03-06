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
    /// Interaction logic for AtlasPage.xaml
    /// </summary>
    public partial class AtlasPage : Page
    {
        public AtlasPage()
        {
            InitializeComponent();

            GardenManagementDBEntities db = new GardenManagementDBEntities();
            var Ts = from d in db.Atlas
                     select new
                     {
                         Plant = d.nazwa,

                     }; 

            this.AtlasGrid.ItemsSource = Ts.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //object productItem = AtlasGrid.SelectedItem; //Datagrid bound with ProductItem
            dynamic customerRow = AtlasGrid.SelectedItem;
         //   MessageBox.Show(customerRow.Plant + "");

            Console.WriteLine(AtlasGrid.SelectedItem);
            Console.WriteLine(customerRow.Plant);
           // AtlasSingleReportPage singleReportPage = new AtlasSingleReportPage();
                this.NavigationService.Navigate(new AtlasSingleReportPage(customerRow.Plant));
           
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
