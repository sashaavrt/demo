   M S B A M L   `   `   `  ����C  ?demoexam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demoexamdemoexam  5   	       demoexam.AddUserWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demoexam     5   	     � Title$)  #Новый пользователь��5   	   $	��350��6$   $	��550��64    � SizeToContent$ WidthAndHeight=�6C    � 
ResizeMode$ 	CanResize=�6b   ��5	      �� 5
   
    �� Color$ #C9D7B3��6   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $)��#Новый пользователь��5      $��24(�5      $
��Bold"�5      ���#5D3F57$��Center=�5      $��0, 10q�5      $��Cascadia Code)�5      �� 5   
   $��1��5      $��Center=�6   $	��400��65   $��Center=�6A   .+�5      �� $��Имя��6   $��16(�6#   ���#5D3F57$��Cascadia Code)�6F   �� 5      -   5         ��Name$ Username��5      $��0, 10q�5      $
��Bold"�5      ���#5D3F57$��Cascadia Code)�5       $��35��5!      $��20(�5"      $��Center=�5#      ���#D7E7BF
������ 5%      �� 5&      $��Роль��6   $��16(�6$   ���#5D3F57$��Cascadia Code)�6G   �� 5'      -   5        $
 Role��5'      $��0, 10q�5(   
   $
��Bold"�5)   
   ���#5D3F57$��Cascadia Code)�5+   
   $��35��5,   
   $��20(�5-   
   $��Center=�5.   
   ���#D7E7BF
������ 50   
   �� 51      $��Email��6   $��16(�6%   ���#5D3F57$��Cascadia Code)�6H   �� 52      -   5        $ Email��52      $��0, 10q�53   
   $
��Bold"�54   
   ���#5D3F57$��Cascadia Code)�56   
   $��35��57   
   $��20(�58   
   $��Center=�59   
   ���#D7E7BF
������ 5;   
   �� 5<      $��Пароль��6   $��16(�6&   ���#5D3F57$��Cascadia Code)�6I   �� 5=      -   5        $ Password��5=      $��0, 10q�5>   
   $
��Bold"�5?   
   ���#5D3F57$��Cascadia Code)�5A   
   $��35��5B   
   $��20(�5C   
   $��Center=�5D   
   ���#D7E7BF
������ 5F   
   �� 5G      -   5        $��Сохранить��5H      $	��180��5I      $��35��5J      ���#5D3F57���#D7E7BF$��Cascadia Code)�5M      $��18(�5N      $
��Bold"�5O      $��0q�5P       � Cursor$
 Hand��5Q      $��0 15 0 0q�5R      6#   5S      5T      5V      