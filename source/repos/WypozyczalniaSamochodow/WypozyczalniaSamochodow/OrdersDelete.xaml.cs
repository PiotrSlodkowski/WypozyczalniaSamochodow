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
    /// Logika interakcji dla klasy OrdersDelete.xaml
    /// </summary>
    public partial class OrdersDelete : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();
        public void SelectOrdersList()
        {
            var query =
            from Orders in wypozyczalniaSamochodow.OrdersTable
            join Equipment in wypozyczalniaSamochodow.EquipmentTable
            on Orders.EquipmentId equals Equipment.idEquipment
            join Client in wypozyczalniaSamochodow.ClientTable
            on Orders.ClientId equals Client.idClient
            where Orders.status != -1
            orderby Orders.idOrders
            select new { Orders.idOrders, Client.name, Client.surname, Orders.rentalDate, Orders.returnTerm, Orders.returnDate,  Equipment.brand, Equipment.model, Equipment.yearOfProduction };


            foreach (var element in query.ToList())
                Orders_comboBox.Items.Add(new ComboBoxItem("Zamówienie nr " + element.idOrders + " (" + element.name + " " + element.surname + "; samochód " + element.brand + " " + element.model + ", rok " + element.yearOfProduction + ")", element.idOrders));
            
        }
        public OrdersDelete()
        {
            InitializeComponent();
            SelectOrdersList();
        }

        private void OrdersDelete_Button(object sender, RoutedEventArgs e)
        {
            int idOrders = (Orders_comboBox.SelectedItem as ComboBoxItem).Value;

            var result = wypozyczalniaSamochodow.OrdersTable.SingleOrDefault(m => m.idOrders == idOrders);
            result.status = -1;

            wypozyczalniaSamochodow.SaveChanges();

            Orders_comboBox.Items.Clear();
            SelectOrdersList();

            MessageBox.Show("Zamówienie zostało usunięte!");

        }
    }
}
