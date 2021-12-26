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
            orderby Orders.idOrders
            select new { Imię_Klienta = Client.name, Nazwisko_Klienta = Client.surname, Data_Wypożyczenia = Orders.rentalDate, Termin_Zwrotu = Orders.returnTerm, Data_Zwrotu = Orders.returnDate, Marka = Equipment.brand, Model = Equipment.model , Rok_Produkcji = Equipment.yearOfProduction };
            
            OrdersList.ItemsSource = query.ToList();
        }

    }
}
