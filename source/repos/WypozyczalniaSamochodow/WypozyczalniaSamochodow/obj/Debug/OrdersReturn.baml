   M S B A M L   `   `   `  ����R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  5   	   *    $WypozyczalniaSamochodow.OrdersReturn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WypozyczalniaSamochodow     5   	     � Title$"  Ewidencja zamówień - zwrot��5   	   $	��450��6,   $	��800��69    � 
ResizeMode$ NoResize=�6E    � Icon$ images\background.jpg��5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.jpg��6    j� Stretch$ UniformToFill=�6=   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��348��6@   $��
243,45,0,0q�6M   
���   �$	��Top=�6p   $	��335��6�   �� 5   
   $��Zamówienie:��6   $
��Left=�6&   $��
259,59,0,0q�6A   $	��Top=�6U   $	��120��6m   �� 5   
   -   5         ��Name$ Orders_comboBox��5      $
��Left=�6,   $��
259,90,0,0q�6G   $	��Top=�6[   $	��120��6s   �� 5   
   $��Data zwrotu:��6   $
��Left=�6'   $��259,117,0,0q�6B   $	��Top=�6W    J� RenderTransformOrigin$ 1.135,0.178&�6o   $	��120��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ Calendar��5      $
��Left=�6%   $��259,143,0,0q�6@   $	��Top=�6U   �� 5   
   -   5        $��Zapisz��5      $
��Left=�6"   $��259,347,0,0q�6=   $	��Top=�6R   $��75��6j   $ -1.702,-0.05&�6�   5      5      