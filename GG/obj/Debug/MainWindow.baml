   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AMONICAMONIC  5   	       AMONIC.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AMONIC     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Login��5
   	   $	��450��6   $	��650��6$    � Icon$ 	/Icon.png��60   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $	��200 �6   6+   .+�5   
   �� $	��400��6   $	��200��6   $��/DS2017_TP09_color.png��6)   6K   �� 5   
   -   5         ��Name$ Txb_Name��5   1   $��TeX Gyre Adventor)�6   $��0,20,0,0q�6C   $	��Top=�6U   $��1��6m   $	��400��6z   $��25��6�   6�   �� 5   
   -   5        $ Txb_Pass��5   1   $��TeX Gyre Adventor)�6   $��0,80,0,0q�6C   $	��Top=�6U   $��1��6m   $	��400��6z   $��25��6�   6�   �� 5   
   $��71��6   $��25��6   $��
0,20,470,0q�6'   $	��Top=�6;   $��	Username:��6S   $��1��6g   $��TeX Gyre Adventor)�6t   6�   �� 5   
   $��71��6   $��25��6   $��
0,80,470,0q�6'   $	��Top=�6;   $��	Password:��6S   $��1��6g   $��TeX Gyre Adventor)�6t   6�   �� 5   
   -   5         ��Name$ Btn_Log��5   '   $��0,100,225,0q�68   $��Login��6M   
�������$	��150��6p   $��25��6|   $��1��6�   $��TeX Gyre Adventor)�6�   6�   �� 5   
   -   5        $ Btn_Exit��5   (   $��225,100,0,0q�6:   $
��Exit��6O   
�������$	��150��6q   $��25��6}   $��1��6�   $��TeX Gyre Adventor)�6�   6�   5      5      