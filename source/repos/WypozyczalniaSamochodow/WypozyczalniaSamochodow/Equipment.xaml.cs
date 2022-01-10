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
    ///

    class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool access = System.Convert.ToBoolean(value);
            if (access == true)
                return "Wolny";
            else
                return "Wypożyczony";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string access = System.Convert.ToString(value);
            if (access == "Wolny")
                return 1;
            else
                return 0;
        }

    }

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
            where Equipment.access != -1
            orderby Equipment.idEquipment
            select new { Equipment.idEquipment, Equipment.brand, Equipment.model, Equipment.yearOfProduction, Equipment.countOfDoors, Equipment.pricePerDay, Equipment.access };

            EquipmentList.ItemsSource = query.ToList();
        }

    }
}
