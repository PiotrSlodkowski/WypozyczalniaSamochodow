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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WypozyczalniaSamochodow
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowOrdersWindow_Button(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void ShowEquipmentWindow_Button(object sender, RoutedEventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ShowOrdersAddWindow_Button(object sender, RoutedEventArgs e)
        {
            OrdersAdd ordersAdd = new OrdersAdd();
            ordersAdd.ShowDialog();
        }

        private void ShowEquipmentAddWindow_Button(object sender, RoutedEventArgs e)
        {
            EquipmentAdd equipmentAdd = new EquipmentAdd();
            equipmentAdd.ShowDialog();
 
        }
        private void ShowOrdersReturnWindow_Button(object sender, RoutedEventArgs e)
        {
            OrdersReturn ordersReturn = new OrdersReturn();
            ordersReturn.ShowDialog();
        }

        private void ShowEquipmentDeleteWindow_Button(object sender, RoutedEventArgs e)
        {
            EquipmentDelete equipmentDelete = new EquipmentDelete();
            equipmentDelete.ShowDialog();
        }

    }
}
