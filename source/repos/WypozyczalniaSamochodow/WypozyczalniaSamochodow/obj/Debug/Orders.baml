   M S B A M L   `   `   `  ����R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  5   	   $    WypozyczalniaSamochodow.Orders   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WypozyczalniaSamochodow     5   	     � Title$  Ewidencja zamówień��5   	   $	��450��6$   $	��800��61    � 
ResizeMode$ NoResize=�6=    � Icon$ images\background.jpg��5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.jpg��6    j� Stretch$ UniformToFill=�6=   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
OrdersList��5         
IsReadOnly .    AutoGenerateColumns .  $	��354��6S   $��
48,27,47,0q�6`   $	��Top=�6t   $	��699��6�   $��Center=�6�    �� TextAlignment$ Center=�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nr zamówienia��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
idOrders+6[     5      $
 Cena zamówienia (w zł)��6%    6E   �� *priceOfOrder+ �� StringFormat$ N2��6y     5      $
 Zniżka (w %)��6%    6;   �� *
discount+6Z     5      $
 Imię klienta��6%    6;   �� *name+6V     5      $
 Nazwisko klienta��6%    6?   �� *	surname+6]     5      $
 Data wypożyczenia��6%    6@   �� *
rentalDate+$ {0:yyyy-MM-dd}��6�     5      $
 Termin zwrotu��6%    6<   �� *
returnTerm+$ {0:yyyy-MM-dd}��6|     5      $
 Data zwrotu��6%    6:   �� *
returnDate+$ {0:yyyy-MM-dd}��6z     5      $
 Nr ewidencyjny��6%    6=   �� *idEquipment+6_     5      $
 Marka��6%    64   �� *brand+6P     5      $
 Model��6%    64   �� *model+6P     5      $
 Rok produkcji��6%    6<   �� *yearOfProduction+6c   5      5      5      