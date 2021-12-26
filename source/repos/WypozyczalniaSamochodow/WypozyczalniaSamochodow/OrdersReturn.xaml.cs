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
    /// Logika interakcji dla klasy OrdersReturn.xaml
    /// </summary>
    public partial class OrdersReturn : Window
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
            where Orders.returnDate.ToString() == ""
            orderby Orders.idOrders
            select new { Id = Orders.idOrders, Imie_Klienta = Client.name, Nazwisko_Klienta = Client.surname, Data_Wypożyczenia = Orders.rentalDate, Termin_Zwrotu = Orders.returnTerm, Data_Zwrotu = Orders.returnDate, Marka = Equipment.brand, Model = Equipment.model, Rok_Produkcji = Equipment.yearOfProduction };


            foreach (var element in query.ToList())
            {
                Orders_comboBox.Items.Add(new ComboBoxItem("Zamówienie nr " + element.Id + " (" + element.Imie_Klienta + " " + element.Nazwisko_Klienta + "; samochód " + element.Marka + " " + element.Model + ", rok " + element.Rok_Produkcji +")", element.Id));
            }
        }
        public OrdersReturn()
        {
            InitializeComponent();
            SelectOrdersList();
        }

        private void OrdersReturn_Button(object sender, RoutedEventArgs e)
        {
            int idOrders = (Orders_comboBox.SelectedItem as ComboBoxItem).Value;
            DateTime Selected_Date = Calendar.SelectedDate.Value;

            var result = wypozyczalniaSamochodow.OrdersTable.SingleOrDefault(m => m.idOrders == idOrders);
            result.returnDate = Selected_Date;

            var result2 = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == result.EquipmentId);
            result2.access = 1;

            wypozyczalniaSamochodow.SaveChanges();

            Orders_comboBox.Items.Clear();
            SelectOrdersList();

            MessageBox.Show("Sprzęt zwrócono pomyślnie!");


        }
    }
}
