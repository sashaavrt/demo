   M S B A M L   `   `   `  ����C  ?demoexam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demoexamdemoexam  5   	       demoexam.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demoexam     5   	     � Title$  Авторизация��5   	   $	��350��6   $	��550��6-    � SizeToContent$ WidthAndHeight=�6<    � 
ResizeMode$ 	CanResize=�6[   ��5	      �� 5
   
    �� Color$ #C9D7B3��6   .��5   
   � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Авторизация��5      $��24(�5      $
��Bold"�5      ���#5D3F57$��Center=�5      $��0, 10q�5      $��Cascadia Code)�5      �� 5   
   $��1��5      $��Center=�6   $	��400��65   $��Center=�6A   .+�5      �� $��
Логин��6   $��16(�6%   ���#5D3F57$��Cascadia Code)�6H   �� 5      -   5         ��Name$ Username��5      $��0, 10q�5      $
��Bold"�5      ���#5D3F57$��Cascadia Code)�5       $��35��5!      $��20(�5"      $��Center=�5#      ���#D7E7BF
������ 5%      �� 5&      $��Пароль��6   $��16(�6&   ���#5D3F57$��Cascadia Code)�6I   G� 5'      -   5         G�Name$ Password��5'      $��0, 10q�5(      $
��Bold"�5)      ���#5D3F57$��Cascadia Code)�5+      $��35��5,      $��Center=�5-      $��20(�5.      ���#D7E7BF
������ 50      �� 51      -   5        $��
Войти��52      $	��150��53      $��35��54      ���#5D3F57���#D7E7BF$��Cascadia Code)�57      $��18(�58      $
��Bold"�59      $��0q�5:       � Cursor$
 Hand��5;      $��0 15 0 0q�5<      6#   5=      5>      5@      