   M S B A M L   `   `   `  ���� R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  $    WypozyczalniaSamochodow.Orders   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:WypozyczalniaSamochodow       � Title$  Ewidencja zamówień��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � Icon$` ZC:\Users\Slodki\source\repos\WypozyczalniaSamochodow\WypozyczalniaSamochodow\image\tlo.jpg��.��� ����  �� ImageSource$` ZC:\Users\Slodki\source\repos\WypozyczalniaSamochodow\WypozyczalniaSamochodow\image\tlo.jpg�� j� Stretch$ UniformToFill=�.+�&   System.Windows.Controls.DataGrid  -   $��
OrdersList��   
IsReadOnly .    AutoGenerateColumns .  $	��354��$��
48,27,47,0q�$	��Top=�$	��699��$��Center=� �� TextAlignment$ Center=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nr zamówienia��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
idOrders+  $
 Cena zamówienia (w zł)�� �� *priceOfOrder+  $
 Imię klienta�� �� *name+  $
 Nazwisko klienta�� �� *	surname+  $
 Data wypożyczenia�� �� *
rentalDate+  $
 Termin zwrotu�� �� *
returnTerm+  $
 Data zwrotu�� �� *
returnDate+  $
 Marka�� �� *brand+  $
 Model�� �� *model+  $
 Rok produkcji�� �� *yearOfProduction+