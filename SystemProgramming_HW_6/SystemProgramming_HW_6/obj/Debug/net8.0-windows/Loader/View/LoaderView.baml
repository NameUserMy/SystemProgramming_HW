   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:SystemProgramming_HW_6.Loader.View"SystemProgramming_HW_6.Loader.View  5      3    -SystemProgramming_HW_6.Loader.View.LoaderView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:SystemProgramming_HW_6.Loader.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   6.   �� 5      6"   �� 5      $
��0.5* �6   6/   .+�5   
   �� $��0��6   $��0��6    $��Source��60   6C   �� 5   
   $��1��6   $��0��6    $��Destination��60   6H   �� 5   
   -   5         ��Name$ sourceTextBox��5   A   $��5,5,5,5q�6   $��0��6#   $��1��61   ��6X   �� *GetSourceAdress+6{   �� 5   
   -   5        $ destinationTextBox��5   A   $��5,5,5,5q�6   $��1��6#   $��1��61   ��6]   �� *GetDestinationAdress+6�   �� 5   
   -   5         ��Name$ sourceButton��5   B   $��5,5,5,5q�6   $��0��6#   $��2��61   $��Source Load��6X   6�   �� 5   
   -   5        $ destinationButton��5   B   $��5,5,5,5q�6   $��1��6#   $��2��61   $��Destination save��6]   6�   �� 5   
   -   5        $ startCopyButton��5   B   $��5,5,5,5q�6   $��2��6#   $��2��61   $��	Replicate��6[   6�   � 5   
   -   5         �Name$ progressBar��5   H   $��5,5,5,5q�6   $��2��6'   $��2��64    � Maximum 6]   �� *MaxValueProggres+ � Value 6�   �� *ProggresValue+6�   5       5!      