   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:SystemProgramming_HW_6.OneReadOneView.View*SystemProgramming_HW_6.OneReadOneView.View  5      8    2SystemProgramming_HW_6.OneReadOneView.View.OneRead   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:SystemProgramming_HW_6.OneReadOneView.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ CountNumber��5   >   $��0��6   $��0��6   $��5,5,5,5q�6-   $��500000000 iterations��6S   6t   �� 5   
   -   5        $��startSaveButton��5   ]   $��0��6   $��1��6   $��5,5,5,5q�6/   $��Start save in file��6@   6�   �� 5   
   -   5        $��tt��5      $��1��6   $��0��6'   ��67   �� *
GetMessage+6X   �� 5   
   -   5        $��startReadButton��5   Z   $��1��6   $��1��6   $��5,5,5,5q�6/   $��startReadButton��6@   {�6�   �� *
IsEnable+6�   �� 5   
   -   5         ��Name$ 	firstList��5   B   $��2��6   $��0��6    $��5,5,5,5q�61   ��6U   �� *FirstThread+6|   �� 5   
   -   5        $ 
SecondList��5   B   $��2��6   $��1��6    $��5,5,5,5q�61   ��6V   �� *SecondThread+6~   5      5      