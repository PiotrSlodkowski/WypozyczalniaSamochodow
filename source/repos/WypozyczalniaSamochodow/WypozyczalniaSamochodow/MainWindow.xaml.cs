using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.HSSF.UserModel;
using System;
using System.IO;
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
        wypozyczalniaSamochodowEntities wypozyczalniaSamochodow = new wypozyczalniaSamochodowEntities();

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

        private void GenerateDelayedRaport_Button(object sender, RoutedEventArgs e)
        {
            
            var query =
            from Orders in wypozyczalniaSamochodow.OrdersTable
            join Equipment in wypozyczalniaSamochodow.EquipmentTable
            on Orders.EquipmentId equals Equipment.idEquipment
            join Client in wypozyczalniaSamochodow.ClientTable
            on Orders.ClientId equals Client.idClient
            where (Orders.returnDate.ToString() == "" && Orders.returnTerm < DateTime.Now) || Orders.returnTerm < Orders.returnDate
            orderby Orders.returnTerm descending
            select new { Orders.idOrders, Orders.priceOfOrder, Client.name, Client.surname, Orders.rentalDate, Orders.returnTerm, Orders.returnDate, Equipment.idEquipment, Equipment.brand, Equipment.model, Equipment.yearOfProduction, };

            if (query.ToList().Count == 0)
            {
                MessageBox.Show("Brak opóźnionych zwrotów");
                return;
            }

            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Opóźnione zwroty");
            IRow row;

            row = sheet.CreateRow(0);
            row.CreateCell(0).SetCellValue("Nr zamówienia");
            row.CreateCell(1).SetCellValue("Cena zamówienia");
            row.CreateCell(2).SetCellValue("Imię klienta");
            row.CreateCell(3).SetCellValue("Nazwisko klienta");
            row.CreateCell(4).SetCellValue("Data wypożyczenia");
            row.CreateCell(5).SetCellValue("Termin zwrotu");
            row.CreateCell(6).SetCellValue("Data zwrotu");
            row.CreateCell(7).SetCellValue("Opóźnienie (w dniach)");
            row.CreateCell(8).SetCellValue("Kara (w zł)");
            row.CreateCell(9).SetCellValue("Nr ewidencyjny pojazdu");
            row.CreateCell(10).SetCellValue("Marka");
            row.CreateCell(11).SetCellValue("Model");
            row.CreateCell(12).SetCellValue("Rok produkcji");


            int i = 1;
            double delayedDays = 0;

            foreach (var element in query.ToList())
            {
                if (element.returnDate == null)
                    delayedDays = Math.Floor((DateTime.Now - Convert.ToDateTime(element.returnTerm)).TotalDays);
                else
                    delayedDays = Math.Floor((Convert.ToDateTime(element.returnDate) - Convert.ToDateTime(element.returnTerm)).TotalDays);

                row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(element.idOrders);
                row.CreateCell(1).SetCellValue(Convert.ToDouble(element.priceOfOrder));
                row.CreateCell(2).SetCellValue(element.name.ToString());
                row.CreateCell(3).SetCellValue(element.surname.ToString());
                row.CreateCell(4).SetCellValue(Convert.ToDateTime(element.rentalDate).ToString("yyyy-MM-dd"));
                row.CreateCell(5).SetCellValue(Convert.ToDateTime(element.returnTerm).ToString("yyyy-MM-dd"));
                if (element.returnDate != null)
                    row.CreateCell(6).SetCellValue(Convert.ToDateTime(element.returnDate).ToString("yyyy-MM-dd"));
                else
                    row.CreateCell(6).SetCellValue("-");
                row.CreateCell(7).SetCellValue(delayedDays);
                row.CreateCell(8).SetCellValue(delayedDays*60);
                row.CreateCell(9).SetCellValue(element.idEquipment);
                row.CreateCell(10).SetCellValue(element.brand.ToString());
                row.CreateCell(11).SetCellValue(element.model.ToString());
                row.CreateCell(12).SetCellValue(Convert.ToDouble(element.yearOfProduction));

                i++;
            }

            try
            {
                FileStream sw = File.Create("delayed_raport_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".xlsx");
                workbook.Write(sw);
                sw.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Nastąpił błąd zapisu. Spróbuj ponownie!");

            }
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

        private void ShowOrdersDeleteWindows_Button(object sender, RoutedEventArgs e)
        {
            OrdersDelete ordersDelete = new OrdersDelete();
            ordersDelete.ShowDialog();
        }

        private void ShowOrdersEditWindows_Button(object sender, RoutedEventArgs e)
        {
            OrdersEdit ordersEdit = new OrdersEdit();
            ordersEdit.ShowDialog();
        }

        private void ShowEquipmentEditWindows_Button(object sender, RoutedEventArgs e)
        {
            EquipmentEdit equipmentEdit = new EquipmentEdit();
            equipmentEdit.ShowDialog();
        }
    }
}
