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
    /// Logika interakcji dla klasy EquipmentEdit.xaml
    /// </summary>
    public partial class EquipmentEdit : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();
        int idEquipment = 0;
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

        public EquipmentEdit()
        {
            InitializeComponent();
            SelectEquipmentList();

            countOfDoors_comboBox.Items.Add("3");
            countOfDoors_comboBox.Items.Add("5");

            pricePerDay_comboBox.Items.Add("30");
            pricePerDay_comboBox.Items.Add("40");
            pricePerDay_comboBox.Items.Add("50");

            for (int i = 1990; i < 2019; i++)
            {
                yearOfProduction_comboBox.Items.Add(i);
            }
        }

        private void Equipment_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                idEquipment = (Equipment_comboBox.SelectedItem as ComboBoxItem).Value;

                var result = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == idEquipment);
                brand_textBox.Text = result.brand;
                model_textBox.Text = result.model;
                yearOfProduction_comboBox.Text = result.yearOfProduction.ToString();
                countOfDoors_comboBox.Text = result.countOfDoors.ToString();
                pricePerDay_comboBox.Text = result.pricePerDay.ToString().Split(',')[0];
            }
            else
            {
                brand_textBox.Text = "";
                model_textBox.Text = "";
                yearOfProduction_comboBox.Text = "";
                countOfDoors_comboBox.Text = "";
                pricePerDay_comboBox.Text = "";
            }
        }

        private void EquipmentEdit_Button(object sender, RoutedEventArgs e)
        {
            if (Equipment_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano sprzętu do edycji");
                return;
            }

            idEquipment = (Equipment_comboBox.SelectedItem as ComboBoxItem).Value;

            if (brand_textBox.Text == "")
            {
                MessageBox.Show("Nie podano marki");
                return;
            }
            if (model_textBox.Text == "")
            {
                MessageBox.Show("Nie podano modelu");
                return;
            }

            var result = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == idEquipment);
            result.brand = brand_textBox.Text;
            result.model = model_textBox.Text;
            result.yearOfProduction = Int32.Parse(yearOfProduction_comboBox.Text);
            result.countOfDoors = Int32.Parse(countOfDoors_comboBox.Text);
            result.pricePerDay = Int32.Parse(pricePerDay_comboBox.Text);

            wypozyczalniaSamochodow.SaveChanges();

            Equipment_comboBox.Items.Clear();
            SelectEquipmentList();

            MessageBox.Show("Sprzęt został edytowany!");

        }
    }
}
