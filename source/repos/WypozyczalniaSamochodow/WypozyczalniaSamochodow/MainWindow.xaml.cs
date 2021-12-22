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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
