   M S B A M L   `   `   `  ����R  NWypozyczalniaSamochodow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WypozyczalniaSamochodowWypozyczalniaSamochodow  5   	   +    %WypozyczalniaSamochodow.EquipmentEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WypozyczalniaSamochodow     5   	     � Title$#  Ewidencja sprzętów - edytuj��5   	   $	��450��6-   $	��800��6:    � 
ResizeMode$ NoResize=�6F    � Icon$ images\background.jpg��5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.jpg��6    j� Stretch$ UniformToFill=�6=   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��342��6@   $��
243,29,0,0q�6M   
���   �$	��Top=�6p   $	��335��6�   �� 5   
   $��Marka samochodu:��6   $
��Left=�6+   $��
422,39,0,0q�6F   $	��Top=�6Z   $	��120��6r   �� 5   
   -   5         ��Name$ brand_textBox��5      $
��Left=�6)   $��23��6D   $��
422,65,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�    J� RenderTransformOrigin$ 0.492,-0.043&�6�   �� 5   
   $��Model samochodu:��6   $
��Left=�6+   $��
422,93,0,0q�6F   $	��Top=�6Z   $ 1.135,0.178&�6r   $	��120��6�   �� 5   
   -   5        $ model_textBox��5      $
��Left=�6)   $��23��6D   $��422,119,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   $��Rok produkcji:��6   $
��Left=�6)   $��422,147,0,0q�6D   $	��Top=�6Y   $	��120��6q   �� 5   
   $��Liczba drzwi:��6   $
��Left=�6(   $��422,200,0,0q�6C   $	��Top=�6X   �� 5   
   -   5        $��Zmień��5      $
��Left=�6!   $��422,341,0,0q�6<   $	��Top=�6Q   $��75��6i   $ 0.208,0.192&�6�   �� 5   
   -   5         ��Name$ countOfDoors_comboBox��5      $
��Left=�62   $��422,226,0,0q�6M   $	��Top=�6b   $	��120��6z   �� 5   
   -   5        $ yearOfProduction_comboBox��5      $
��Left=�66   $��422,173,0,0q�6Q   $	��Top=�6f   $	��120��6~   �� 5   
   $��Cena:��6   $
��Left=�6    $��422,253,0,0q�6;   $	��Top=�6P   �� 5   
   -   5        $ pricePerDay_comboBox��5      $
��Left=�61   $��422,279,0,0q�6L   $	��Top=�6a   $	��120��6y   �� 5   
   $��Wybierz sprzęt:��6   $
��Left=�6*   $��
268,39,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ Equipment_comboBox��5      $
��Left=�6/   $��
268,65,0,0q�6J   $	��Top=�6^   $	��120��6v   $ 0.533,-0.091&�6�   6�   5      5      