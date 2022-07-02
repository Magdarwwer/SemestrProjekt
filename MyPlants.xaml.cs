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
    /// Interaction logic for MyPlants.xaml
    /// </summary>
    public partial class MyPlants : Page
    {
        public MyPlants()
        {
            InitializeComponent();

            GardenManagementDBEntities db = new GardenManagementDBEntities();
            var Ts = from d in db.Moje_rosliny
                     select new
                     {
                         Plant = d.nazwa,

                     };

            this.MyPlantGrid.ItemsSource = Ts.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
