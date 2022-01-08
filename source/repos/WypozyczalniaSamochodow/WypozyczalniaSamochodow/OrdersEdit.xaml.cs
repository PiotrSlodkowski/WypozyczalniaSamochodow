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
    /// Logika interakcji dla klasy OrdersEdit.xaml
    /// </summary>
    public partial class OrdersEdit : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();
        int idOrders;

        public OrdersEdit()
        {
            InitializeComponent();
            SelectEquipmentList();
            SelectClientList();
            SelectOrdersList();

            discount_comboBox.Items.Add("0");
            discount_comboBox.Items.Add("10");
            discount_comboBox.Items.Add("20");
            discount_comboBox.Items.Add("30");
            discount_comboBox.Items.Add("40");
            discount_comboBox.Items.Add("50");
        }

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
            select new { Orders.idOrders, Client.name, Client.surname, Orders.rentalDate, Orders.returnTerm, Orders.returnDate, Orders.discount, Equipment.brand, Equipment.model, Equipment.yearOfProduction };


            foreach (var element in query.ToList())
                Orders_comboBox.Items.Add(new ComboBoxItem("Zamówienie nr " + element.idOrders + " (" + element.name + " " + element.surname + "; samochód " + element.brand + " " + element.model + ", rok " + element.yearOfProduction + ")", element.idOrders));

        }
        public void SelectEquipmentList()
        {
            var query =
            from Equipment in wypozyczalniaSamochodow.EquipmentTable
            where Equipment.access == 1
            orderby Equipment.idEquipment
            select new { Equipment.idEquipment, Equipment.brand, Equipment.model, Equipment.yearOfProduction };


            foreach (var element in query.ToList())
                Equipment_comboBox.Items.Add(new ComboBoxItem(element.idEquipment + " " + element.brand + " " + element.model + " (" + element.yearOfProduction + ")", element.idEquipment));

        }

        public void SelectClientList()
        {
            var query =
            from Client in wypozyczalniaSamochodow.ClientTable
            orderby Client.idClient
            select new { Client.idClient, Client.name, Client.surname, Client.PESEL };


            foreach (var element in query.ToList())
                Client_comboBox.Items.Add(new ComboBoxItem(element.name + " " + element.surname + " (" + element.PESEL + ")", element.idClient));

        }

        private void Orders_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                idOrders = (Orders_comboBox.SelectedItem as ComboBoxItem).Value;

                var result = wypozyczalniaSamochodow.OrdersTable.SingleOrDefault(m => m.idOrders == idOrders);
                discount_comboBox.Text = result.discount.ToString();
                Calendar.SelectedDate = result.rentalDate;
            }
            else
            {
                Equipment_comboBox.Text = "";
                Client_comboBox.Text = "";
                discount_comboBox.Text = "";
                Calendar.SelectedDate = DateTime.Now;
            }
        }

        private void OrdersEdit_Button(object sender, RoutedEventArgs e)
        {
            if (Orders_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano zamówienia do edycji");
                return;
            }

            idOrders = (Orders_comboBox.SelectedItem as ComboBoxItem).Value;
            int idEquipment, idClient;


            var editedOrders = wypozyczalniaSamochodow.OrdersTable.SingleOrDefault(m => m.idOrders == idOrders);

            if (Equipment_comboBox.SelectedItem != null)
            {
                idEquipment = (Equipment_comboBox.SelectedItem as ComboBoxItem).Value;
                editedOrders.EquipmentId = idEquipment;        
            }
            if (Client_comboBox.SelectedItem != null)
            {
                idClient = (Client_comboBox.SelectedItem as ComboBoxItem).Value;
                editedOrders.ClientId = idClient;
            }
            var selectEquipment = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == editedOrders.EquipmentId);
            editedOrders.priceOfOrder = editedOrders.priceOfOrder/(100-editedOrders.discount)*100 * (100-Int32.Parse(discount_comboBox.Text))/100;
            if (discount_comboBox.SelectedItem != null)
                editedOrders.discount = Int32.Parse(discount_comboBox.Text);
            editedOrders.rentalDate = Calendar.SelectedDate.Value;
            editedOrders.returnTerm = Calendar.SelectedDate.Value.AddDays(30);


            wypozyczalniaSamochodow.SaveChanges();

            Orders_comboBox.Items.Clear();
            SelectOrdersList();

            MessageBox.Show("Zamówienie zostało edytowane!");
        }
    }
}
