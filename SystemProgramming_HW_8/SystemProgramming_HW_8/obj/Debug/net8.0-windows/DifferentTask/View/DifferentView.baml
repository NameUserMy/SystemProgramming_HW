   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:SystemProgramming_HW_8.DifferentTask.View)SystemProgramming_HW_8.DifferentTask.View  5      =    7SystemProgramming_HW_8.DifferentTask.View.DifferentView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:SystemProgramming_HW_8.DifferentTask.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��0.2* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��
Start task��6-   6D   �� 5   
   $��0��6   $��1��6   ��6-   �� *	StartTime+6M   �� 5   
   -   5         ��Name$ 	startTask��5   A   $��0��6   $��2��6   $��	5,5,5,2.5q�6.   $��
Start task��6T   6�   �� 5   
   $��1��6   $��0��6   $��Factory task��6-   6F   �� 5   
   $��1��6   $��1��6   ��6-   �� *FactoryTime+6O   �� 5   
   -   5        $ factoryTask��5   A   $��1��6   $��2��6   $��	5,5,5,2.5q�6.   $��Factory task��6V   6�   �� 5   
   $��2��6   $��0��6   $��Run task��6-   6B   �� 5   
   $��2��6   $��1��6   ��6-   �� *	RunTime+6K   �� 5    
   -   5        $ runTask��5    A   $��2��6   $��2��6   $��	5,5,5,2.5q�6.   $��Run task��6R   6}   �� 5"   
   $��3��6   $��0��6   $��Run async task��6-   6H   �� 5#   
   $��3��6   $��1��6   ��6-   �� *RunAsuncTime+6P   �� 5$   
   -   5        $ runAsyncTask��5$   A   $��3��6   $��2��6   $��	5,5,5,2.5q�6.   $��Run async task��6W   6�   5&      5'      