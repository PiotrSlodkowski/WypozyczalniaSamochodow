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
using System.Windows.Shapes;

namespace WypozyczalniaSamochodow
{
    /// <summary>
    /// Logika interakcji dla klasy Equipment.xaml
    /// </summary>
    public partial class Equipment : Window
    {

        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();

        public Equipment()
        {
            InitializeComponent();

            SelectListOfEquipment();
        }

        private void SelectListOfEquipment()
        {
            var query =
            from Equipment in wypozyczalniaSamochodow.EquipmentTable
            orderby Equipment.idEquipment
            select new { Equipment.idEquipment, Equipment.brand, Equipment.model, Equipment.yearOfProduction, Equipment.countOfDoors, Equipment.pricePerDay };

            EquipmentList.ItemsSource = query.ToList();
        }

    }
}
