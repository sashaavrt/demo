   M S B A M L   `   `   `  ����C  ?demoexam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demoexamdemoexam  5   	       demoexam.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demoexam     5   	     � Title$   Администратор��5	   	   $	��350��6   $	��550��6/    � SizeToContent$ WidthAndHeight=�6>    � 
ResizeMode$ 	CanResize=�6]   ��5
      �� 5   
    �� Color$ #C9D7B3��6   .��5      �� $��20q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Users��5         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         SelectionMode$ Single=�5         CanUserDeleteRows$
 True��5      $��Stretch=�5      $��Stretch=�5      $
��auto��5      $��10,10,10,10q�5      	   
IsReadOnly$	 False��5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K     5      $ Роль��6%   $
 Auto 6L    63   �� *Role+6L     5      $ Email��6%   $
 Auto 6N    64   �� *Email+6N     5      $ Пароль��6%   $
 Auto 6R    65   �� *
Password+6R     5      $ Заблокирован��6%   $
 Auto 6X    6;   �� *
IsLocked+6X     5      $ Попыток входа��6%   $
 Auto 6d    6<   �� *FalledLoginAttempts+6d     5       $ Первый вход��6%   $
 Auto 6[    6:   �� *IsFirstLogin+6[     5!      $! Последний вход��6%   $
 Auto 6_    6=   �� *LastLoginDate+6_   5#      �� 5$   
   $��Center=�6   .+�5%      �� -   5        $��Сохранить��5&      $	��150��5'      $��35��5(      ���#5D3F57���#D7E7BF$��Cascadia Code)�5+      $��15(�5,      $��0q�5-       � Cursor$
 Hand��5.      $��0 10 0 0q�5/      6!   �� 50      -   5        $��Добавить��51      $	��150��52      $��35��53      ���#5D3F57���#D7E7BF$��Cascadia Code)�56      $��15(�57      $��0q�58      $
 Hand��59      $��0 10 0 0q�5:      6   5;      5<      5=      