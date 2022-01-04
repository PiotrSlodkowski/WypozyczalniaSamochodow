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
    /// Logika interakcji dla klasy EquipmentAdd.xaml
    /// </summary>
    public partial class EquipmentAdd : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();
        public EquipmentAdd()
        {
            InitializeComponent();

            numberOfDoors_comboBox.Items.Add("3");
            numberOfDoors_comboBox.Items.Add("5");

            pricePerDay_comboBox.Items.Add("30");
            pricePerDay_comboBox.Items.Add("40");
            pricePerDay_comboBox.Items.Add("50");


            for (int i = 1990; i < 2019; i++)
            {
                yearOfProduction_comboBox.Items.Add(i);
            }

        }

        private void EquipmentAdd_Button(object sender, RoutedEventArgs e)
        {
            EquipmentTable addedEquipment = new EquipmentTable();
            addedEquipment.brand = brand_textBox.Text;
            addedEquipment.model = model_textBox.Text;
            addedEquipment.yearOfProduction = Int32.Parse(yearOfProduction_comboBox.Text);
            addedEquipment.countOfDoors = Int32.Parse(numberOfDoors_comboBox.Text);
            addedEquipment.pricePerDay = Int32.Parse(pricePerDay_comboBox.Text);
            addedEquipment.access = 1;

            wypozyczalniaSamochodow.EquipmentTable.Add(addedEquipment);
            wypozyczalniaSamochodow.SaveChanges();

            MessageBox.Show("Sprzęt dodano pomyślnie!");

        }
    }
}
