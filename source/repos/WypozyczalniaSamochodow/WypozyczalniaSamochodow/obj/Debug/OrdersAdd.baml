   M S B A M L   `   `   `  ����R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  5   	   '    !WypozyczalniaSamochodow.OrdersAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WypozyczalniaSamochodow     5   	     � Title$"  Ewidencja zamówień - dodaj��5   	   $	��450��6,   $	��800��69    � 
ResizeMode$ NoResize=�6E    � Icon$ images\background.jpg��5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.jpg��6    j� Stretch$ UniformToFill=�6=   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��351��6@   $��
188,40,0,0q�6M   
���   �$	��Top=�6p   $	��455��6�   �� 5   
   $��Sprzęt:��6   $
��Left=�6"   $��
214,40,0,0q�6=   $	��Top=�6Q   $	��120��6i   �� 5   
   -   5         ��Name$ Equipment_comboBox��5      $
��Left=�6/   $��
214,66,0,0q�6J   $	��Top=�6^   $	��120��6v    J� RenderTransformOrigin$ 0.058,0.545&�6�   �� 5   
   $��Klient:��6   $
��Left=�6"   $��
214,98,0,0q�6=   $	��Top=�6Q   $ 1.135,0.178&�6i   $	��120��6�   �� 5   
   -   5        $ Client_comboBox��5      $
��Left=�6,   $��214,124,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5   
   $��Data wypożyczenia:��6   $
��Left=�6-   $��
431,40,0,0q�6H   $	��Top=�6\   $ 1.135,0.178&�6t   $	��120��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ Calendar��5      $
��Left=�6%   $��
431,66,0,0q�6@   $	��Top=�6T   $	��169��6l   $	��172��6y   �� 5   
   -   5        $��Dodaj��5      $
��Left=�6!   $��214,338,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   �� 5   
   $��Wybrana zniżka:��6   $
��Left=�6*   $��214,156,0,0q�6E   $	��Top=�6Z   $ 	0.448,0.5&�6r   �� 5   
   -   5        $ discount_comboBox��5      $
��Left=�6.   $��214,182,0,0q�6I   $	��Top=�6^   $	��120��6v   5      5      