   M S B A M L   `   `   `  ����K  GInimesteKuvamine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InimesteKuvamineInimesteKuvamine  5   	   !    InimesteKuvamine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:InimesteKuvamine     5   	     � Title$  
MainWindow��5   	   $��376.471��6   $��592.647��6-   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� $
��Left=�6   $��	35,38,0,0q�6/   $
��Wrap=�6B   $��Eesnimi��6V   $	��Top=�6e   $��23��6}   $��63��6�   $��14(�6�   �� 5   
   $
��Left=�6   $��	35,66,0,0q�6/   $
��Wrap=�6B   $��Perenimi��6V   $	��Top=�6f   $��23��6~   $��63��6�   $��14(�6�   �� 5   
   $
��Left=�6   $��	35,94,0,0q�6/   $
��Wrap=�6B   $��Pikkus��6V   $	��Top=�6d   $��23��6|   $��63��6�   $��14(�6�   �� 5   
   -   5         ��Name$ 
txtEesnimi��5      $
��Left=�6&   $��23��6�   $��
103,38,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6A   �� *SelectedItem.Eesnimi+ �� ElementName$ lboxInimesed��6�   �� 5   
   -   5        $ txtPerenimi��5      $
��Left=�6'   $��23��6�   $��
103,66,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6B   �� *SelectedItem.Perenimi+$ lboxInimesed��6�   �� 5   
   -   5        $ 	txtPikkus��5      $
��Left=�6%   $��23��6   $��
103,94,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6@   �� *SelectedItem.Pikkus+$ lboxInimesed��6�   �� 5   
   -   5         ��Name$ btnLisaInimene��5      $
��Lisa��6)   $
��Left=�68   $��228,120,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5         ��Name$ lboxInimesed��5      $
��Left=�6I   $	��190��6d   $��
10,145,0,0q�6q   $	��Top=�6�   $	��563��6�   ��6(   �� *
Inimesed+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *	Eesnimi+6?   �� 5      $��5,0,0,0q�6$   ��65   �� *
Perenimi+6Q   5      5      5      5      5      