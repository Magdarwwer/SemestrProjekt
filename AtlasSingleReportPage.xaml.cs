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
    /// Interaction logic for AtlasSingleReportPage.xaml
    /// </summary>
    public partial class AtlasSingleReportPage : Page
    {
        public AtlasSingleReportPage()
        {
            InitializeComponent();
        }

        public AtlasSingleReportPage(string data)
        {
            InitializeComponent();
            Console.WriteLine("chuj");
            Console.WriteLine(data);

            GardenManagementDBEntities db = new GardenManagementDBEntities();
            var plant = db.Atlas
                            .Where(d => d.nazwa == data)
                            .FirstOrDefault();

            Console.WriteLine(plant.podlewanie + plant.ogrodowa + plant.stanowisko);

            TxtName.Text = plant.nazwa;
            TxtPlacement.Text = plant.stanowisko;
            TxtWatering.Text = plant.podlewanie;
            TxtIndoorOutdoor.Text = plant.domowa + "/" + plant.ogrodowa;
        }

        
    }
}
