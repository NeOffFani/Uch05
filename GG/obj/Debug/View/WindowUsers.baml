   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AMONIC.ViewAMONIC.View  5   	       AMONIC.View.WindowUsers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AMONIC.View     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$' !AMONIC Airlines Automation System��5   	   $	��650��63   $	��800��6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $��25 �6   6,   �� 5      $	��750 �6   6-   �� 5      $��25 �6   6,    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��65 �6   6*   �� 5      $	��435 �6   6+   �� 5      $��75 �6   6*   .+�5   
   �� -   5        $��TeX Gyre Adventor)�5   !   $
��Left=�6@   
�������$��25��6n   $��80��6z   $��Add user��6�   $��1��6�   $��0��6�   
�������6�   �� 5   
   -   5        $��TeX Gyre Adventor)�5      $��80,0,0,0q�6=   $
��Left=�6O   
�������$��25��6}   $��80��6�   $
��Exit��6�   $��1��6�   $��0��6�   
���   �
�������6�   �� 5   
   $��TeX Gyre Adventor)�6   $
��Left=�6/   $��1��6J   $��1��6W   $��50��6g   $��25��6r   $��Office:��6~   6�   �� 5   
   -   5         ��Name$ ComboBox��5   2   $��TeX Gyre Adventor)�6    �� DisplayMemberPath$ Title��6D   $��1��6^   $��1��6k   $	��200��6{   $��25��6�   $��50,0,0,0q�6�   $
��Left=�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	UsersGrid��5   /      AutoGenerateColumns .  $��1��6B   $��2��6R   	   
IsReadOnly	 . 
   RowStyle
 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5        �� Binding 6&   �� *RoleID+ �� Value 16A   .a�5!      ��  �� Property � �� �� Value
 � � �6K   5"      �� 5#       6&   �� *Active+	 False6A   .a�5$      ��  � ��
 �  ��6I   5%      5'         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ID+6T     5+      $ Роль��6%   $ * 63    6=   �� *Roles.Title+6_     5,      $ Имя��6%   $ * 62    6<   �� *	FirstName+6\     5-      $ Фамилия��6%   $ * 66    6@   �� *
LastName+6_     5.      $ Email адрес��6%   $ * 6:    6D   �� *Email+6`     5/      -   5        	Title��$ Офис��5/   4   $ * 6B    6L   �� *Offices.Title+6p     50      $ Дата рождения��6%   $ * 6<    6F   �� *	Birthdate+6f   52      �� 53   
   -   5        $��TeX Gyre Adventor)�53       $��Сменить роль��6?   
�������$��1��6i   $��3��6y   $	��100��6�   $��25��6�   $
��Left=�6�   $��	0,10,0,40q�6�   6�   �� 54   
   -   5        $��TeX Gyre Adventor)�54   "   $2��,Включить/Отключить роль��6A   
�������$��201,10,0,40q�6v   $��1��6�   $��3��6�   $	��200��6�   $��25��6�   $
��Left=�6�   6�   �� 55   
   -	   5        $��TeX Gyre Adventor)�55       $��	160,0,0,0q�6?   $
��Left=�6R   
�������$��25��6�   $��80��6�   $
��To 2��6�   $��1��6�   $��0��6�   
���   �
�������6�   56      57      