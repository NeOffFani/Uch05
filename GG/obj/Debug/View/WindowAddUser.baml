   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AMONIC.ViewAMONIC.View  5   	       AMONIC.View.WindowAddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AMONIC.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$/ )Добавить пользователя��5
   	   $	��600��6'   $	��600��64   .��5      � .+�5   
   �� -   5         ��Name$ Email��5      $	��300��6!   $��25��6-   $��	0,0,0,498q�69   $��Center=�6L   $��Bottom=�6i   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,498q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   Email Address6�   �� 5   
   -   5        $ FN��5      $	��300��6   $��25��6*   $��	0,0,0,432q�66   $��Center=�6I   $��Bottom=�6f   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,432q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   
First Name6�   �� 5   
   -   5        $ LN��5      $	��300��6   $��25��6*   $��	0,0,0,370q�66   $��Center=�6I   $��Bottom=�6f   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,370q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   	Last Name6   �� 5   
   -   5         ��Name$ Office��5   -    �� DisplayMemberPath$ Title��6   $	��300��6=   $��25��6I   $��	0,0,0,315q�6U   $��Center=�6h   $��Bottom=�6�   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,317q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   Office6|   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 Date��5      $	��300��6#   $��25��6/   $��	0,0,0,252q�6;   $��Bottom=�6N   $��Center=�6i   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,252q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   
Bithdate6~   �� 5   
   -   5        $
 Pass��5      $	��300��6    $��25��6,   $��	0,0,0,202q�68   $��Center=�6K   $��Bottom=�6h   6�   �� 5   
   $	��100��6   $��25��6   $��0,0,450,202q�6(   $��Right=�6=   $��Bottom=�6Y   .��6t   
Password6~   �� 5   
   -   5        $ CmbRole��5   T   $ Title��6    �� 
IsEditable .  $y�Hidden=�6@   $	��300��6e   $��25��6q   $��150,408,150,151q�6}   6�   �� 5   
   -   5        $
��Save��5      $	��100��61   $��25��6=   $��
0,0,350,83q�6I   $��Right=�6]   $��Bottom=�6y   6�   �� 5   
   -	   5        $��Cancel��5      $	��100��65   $��25��6A   $��
0,0,150,83q�6M   $��Right=�6a   $��Bottom=�6}   6�   5      5      