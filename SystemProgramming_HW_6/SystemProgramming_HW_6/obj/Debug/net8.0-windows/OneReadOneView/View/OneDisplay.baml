   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:SystemProgramming_HW_6.OneReadOneView.View*SystemProgramming_HW_6.OneReadOneView.View  5   	   ;    5SystemProgramming_HW_6.OneReadOneView.View.OneDisplay   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:SystemProgramming_HW_6.OneReadOneView.View     5   	     � Title$  
OneDisplay��5   	   $	��400��6   $	��400��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ status��5   -   $��0��6   $��0��6    $��5,5,5,5q�6=   ��6N   �� *
GetMessage+6o   �� 5   
   -   5         ��Name$ 
ReadButtom��5   ?   $��1��6   $��0��6!   $��5,5,5,5q�6.   $��
Start read��6S   6�   �� 5   
   $��2��6   $��1��6'   ��64   �� *DisplayChange+6\   5      5      