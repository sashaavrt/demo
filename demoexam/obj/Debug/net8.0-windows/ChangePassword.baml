   M S B A M L   `   `   `  ����C  ?demoexam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demoexamdemoexam  5   	       demoexam.ChangePassword   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:demoexam     5   	     � Title$!  Сменить пароль��5   	   $	��350��6    $	��550��60    � SizeToContent$ WidthAndHeight=�6?    � 
ResizeMode$ 	CanResize=�6^   ��5	      �� 5
   
    �� Color$ #C9D7B3��6   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Смена пароля��5      $��24(�5      $
��Bold"�5      ���#5D3F57$��Center=�5      $��0, 10q�5      $��Cascadia Code)�5      �� 5   
   $��1��5      $��Center=�6   $	��400��65   $��Center=�6A   .+�5      �� $!��Текущий пароль��6   $��16(�6.   ���#5D3F57$��Cascadia Code)�6Q   G� 5      -   5         G�Name$ CurrentPawword��5      $��0, 10q�5      $
��Bold"�5      ���#5D3F57$��Cascadia Code)�5       $��35��5!      $��20(�5"      $��Center=�5#      ���#D7E7BF
������ 5%      �� 5&      $��Новый пароль��6   $��16(�6,   ���#5D3F57$��Cascadia Code)�6O   G� 5'      -   5        $ NewPassword��5'      $��0, 10q�5(      $
��Bold"�5)      ���#5D3F57$��Cascadia Code)�5+      $��35��5,      $��Center=�5-      $��20(�5.      ���#D7E7BF
������ 50      �� 51      $%��Повторите пароль��6   $��16(�60   ���#5D3F57$��Cascadia Code)�6S   G� 52      -   5        $ CheckPassword��52      $��0, 10q�53      $
��Bold"�54      ���#5D3F57$��Cascadia Code)�56      $��35��57      $��Center=�58      $��20(�59      ���#D7E7BF
������ 5;      �� 5<      -   5        $!��Сменить пароль��5=      $	��180��5>      $��35��5?      ���#5D3F57���#D7E7BF$��Cascadia Code)�5B      $��18(�5C      $
��Bold"�5D      $��0q�5E       � Cursor$
 Hand��5F      $��0 15 0 0q�5G      6#   5H      5I      5K      