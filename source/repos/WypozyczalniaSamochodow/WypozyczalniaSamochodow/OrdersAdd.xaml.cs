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
    /// Logika interakcji dla klasy OrdersAdd.xaml
    /// </summary>
    /// 

    public partial class OrdersAdd : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();

        public OrdersAdd()
        {
            InitializeComponent();
            SelectEquipmentList();
            SelectClientList();

            discount_comboBox.Items.Add("0");
            discount_comboBox.Items.Add("10");
            discount_comboBox.Items.Add("20");
            discount_comboBox.Items.Add("30");
            discount_comboBox.Items.Add("40");
            discount_comboBox.Items.Add("50");
            discount_comboBox.SelectedItem = "0";

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
        private void OrdersAdd_Button(object sender, RoutedEventArgs e)
        {
            DateTime Selected_Date;
            int idEquipment, idClient;

            if (Calendar.SelectedDate == null)
                Selected_Date = DateTime.Now;
            else
                Selected_Date = Calendar.SelectedDate.Value;


            if (Equipment_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano sprzętu");
                return;
            }

            if (Client_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano klienta");
                return;
            }

            idEquipment = (Equipment_comboBox.SelectedItem as ComboBoxItem).Value;
            idClient = (Client_comboBox.SelectedItem as ComboBoxItem).Value;

            OrdersTable addedOrder = new OrdersTable();

            var result = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == idEquipment);

            addedOrder.EquipmentId = idEquipment;
            addedOrder.ClientId = idClient;
            addedOrder.rentalDate = Selected_Date;
            addedOrder.returnTerm = Selected_Date.AddDays(30);
            addedOrder.discount = Int32.Parse(discount_comboBox.Text)/100;
            addedOrder.priceOfOrder = result.pricePerDay * 30 * (100-Int32.Parse(discount_comboBox.Text))/100;
            addedOrder.status = 1;

            wypozyczalniaSamochodow.OrdersTable.Add(addedOrder);

            result.access = 0;

            wypozyczalniaSamochodow.SaveChanges();

            Equipment_comboBox.Items.Clear();
            SelectEquipmentList();

            Equipment_comboBox.Text = "";
            Client_comboBox.Text = "";


            MessageBox.Show("Zamówienie dodano pomyślnie!");

        }

    }
}
