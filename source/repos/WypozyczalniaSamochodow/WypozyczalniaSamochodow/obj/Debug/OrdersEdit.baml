   M S B A M L   `   `   `  ����R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  5   	   (    "WypozyczalniaSamochodow.OrdersEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WypozyczalniaSamochodow     5   	     � Title$#  Ewidencja zamówień - edytuj��5   	   $	��450��6-   $	��800��6:    � 
ResizeMode$ NoResize=�6F    � Icon$ images\background.jpg��5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.jpg��6    j� Stretch$ UniformToFill=�6=   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��351��6@   $��
188,40,0,0q�6M   
���   �$	��Top=�6p   $	��455��6�   �� 5   
   $��Sprzęt:��6   $
��Left=�6"   $��214,121,0,0q�6=   $	��Top=�6R   $	��120��6j   �� 5   
   -   5         ��Name$ Equipment_comboBox��5      $
��Left=�6/   $��214,147,0,0q�6J   $	��Top=�6_   $	��120��6w    J� RenderTransformOrigin$ 0.058,0.545&�6�   �� 5   
   $��Klient:��6   $
��Left=�6"   $��214,179,0,0q�6=   $	��Top=�6R   $ 1.135,0.178&�6j   $	��120��6�   �� 5   
   -   5        $ Client_comboBox��5      $
��Left=�6,   $��214,205,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5   
   $��Data wypożyczenia:��6   $
��Left=�6-   $��429,116,0,0q�6H   $	��Top=�6]   $ 1.135,0.178&�6u   $	��120��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ Calendar��5      $
��Left=�6%   $��429,142,0,0q�6@   $	��Top=�6U   $	��169��6m   $	��172��6z   �� 5   
   -   5        $��Zmień��5      $
��Left=�6!   $��214,338,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   �� 5   
   $��Wybrana zniżka:��6   $
��Left=�6*   $��214,237,0,0q�6E   $	��Top=�6Z   $ 	0.448,0.5&�6r   �� 5   
   -   5        $ discount_comboBox��5      $
��Left=�6.   $��214,263,0,0q�6I   $	��Top=�6^   $	��120��6v   �� 5   
   $��Wybierz zamówienie:��6   $
��Left=�6.   $��
213,50,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ Orders_comboBox��5      $
��Left=�6,   $��
214,81,0,0q�6G   $	��Top=�6[   $	��120��6s   6   5      5      