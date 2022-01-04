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
using System.Globalization;

namespace WypozyczalniaSamochodow
{
    /// <summary>
    /// Logika interakcji dla klasy Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {

        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();

        public Orders()
        {
            InitializeComponent();

            SelectListOfOrders();

        }

        private void SelectListOfOrders()
        {
            var query =
            from Orders in wypozyczalniaSamochodow.OrdersTable
            join Equipment in wypozyczalniaSamochodow.EquipmentTable
            on Orders.EquipmentId equals Equipment.idEquipment
            join Client in wypozyczalniaSamochodow.ClientTable
            on Orders.ClientId equals Client.idClient
            where Orders.status != -1
            orderby Orders.idOrders
            select new { Orders.idOrders, Client.name, Client.surname, Orders.rentalDate, Orders.returnTerm, Orders.returnDate, Orders.priceOfOrder, Equipment.brand, Equipment.model , Equipment.yearOfProduction };

            OrdersList.ItemsSource = query.ToList();

        }

    }
}
