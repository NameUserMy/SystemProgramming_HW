   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SystemProgramming_HW_5.ViewSystemProgramming_HW_5.View  5      /    )SystemProgramming_HW_5.View.StopwatchTest   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SystemProgramming_HW_5.View     5      .��5	      � -   5          �Name$  Mygrid��5	   #   
������ � ColumnDefinitions 5
   
   �� 5      6"   �� 5      6"   �� 5      6"    � RowDefinitions 5   
   �� 5      $
��0.2* �6   6,   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5        $��startProgramm��5   2   $��2��6   $��5,0,5,0q�6!   $&�� Start Locker VS Mutex VS Monitor��6G   6�   �� 5   
   -   5         ��Name$ iterationsCountTextBox��5      $��0��62   $��1��6?   6�   �� 5   
   $��0��6   $��0��6   $��Center=�6-   $��Center=�6J   $&�� Enter Iteration(default 1000000)��6e   6�   �� 5   
   $��1��6   $��0��6   $��Center=�6-   $��Center=�6J   $��
Locker mls��6e   6|   �� 5   
   $��1��6   $��1��6   $��Center=�6-   $��Center=�6J   $��Monitor mls��6e   6}   �� 5   
   $��1��6   $��2��6   $��Center=�6-   $��Center=�6J   $��	Mutex mls��6e   6{   �� 5   
   $��2��6   $��0��6   $��Center=�6-   $��Center=�6J   ��6e   �� *
LockerTime+6�   �� 5   
   $��2��6   $��1��6   $��Center=�6-   $��Center=�6J   ��6e   �� *MonitorTime+6�   �� 5    
   $��2��6   $��2��6   $��Center=�6-   $��Center=�6J   ��6e   �� *	MutexTime+6�   �� 5#   
   $��3��6   $��0��6   $��Center=�6-   $��Center=�6J   ��6e   �� *LockerCounter+6�   �� 5$   
   $��3��6   $��1��6   $��Center=�6-   $��Center=�6J   ��6e   �� *MonitorCounter+6�   �� 5%   
   $��3��6   $��2��6   $��Center=�6-   $��Center=�6J   ��6e   �� *MutexCounter+6�   �� 5&   
   -   5         ��Name$ withCounterChBox��5&   i   $��3��6   $��2��6     � ToolTip$$ Select сheck display сounter��60   $��0,0,15,0q�6W   
�������$��Right=�6�   $��Center=�6�   6�   5'      5(      