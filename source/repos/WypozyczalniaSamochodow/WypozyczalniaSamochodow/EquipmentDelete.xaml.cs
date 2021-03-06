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
    /// Logika interakcji dla klasy EquipmentDelete.xaml
    /// </summary>
    public partial class EquipmentDelete : Window
    {
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();

        public EquipmentDelete()
        {
            InitializeComponent();
            SelectEquipmentList();
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
        private void EquipmentDelete_Button(object sender, RoutedEventArgs e)
        {
            int idEquipment;

            if (Equipment_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano sprzętu");
                return;
            }

            idEquipment = (Equipment_comboBox.SelectedItem as ComboBoxItem).Value;

            var deletedEquipment = wypozyczalniaSamochodow.EquipmentTable.SingleOrDefault(m => m.idEquipment == idEquipment);
            deletedEquipment.access = -1;

            wypozyczalniaSamochodow.SaveChanges();

            Equipment_comboBox.Items.Clear();
            SelectEquipmentList();

            MessageBox.Show("Sprzęt został wycofany!");

        }
    }
}
