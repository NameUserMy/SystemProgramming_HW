   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SystemProgramming_HW_4.TaskArray.View%SystemProgramming_HW_4.TaskArray.View  5   	   5    /SystemProgramming_HW_4.TaskArray.View.TaskArray   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SystemProgramming_HW_4.TaskArray.View     5   	     � Title$  	TaskArray��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6-   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��Inner Array��6-   $��10,0,0,0q�6C   6W   �� 5   
   $��0��6   $��1��6   $��
Sort Array��6-   $��5,0,0,0q�6B   6U   �� 5   
   -   5         ��Name$ generateArrList��5   T   $��	10,0,5,10q�6   $��2��6%   $��0��62   
����� �6o   �� 5   
   -   5        $ sortArrList��5   U   $��	5,0,10,10q�6   $��2��6%   $��1��62   
�������6m   �� 5   
   -   5        $��
findNumber��5   g   $	��150��6   $
��Left=�6   $��5,5,5,5q�69   $��1��6J   $��1��6W   $��Enter number for search��6y   6�   �� 5   
   -   5        $��genereteCount��5   i   $	��150��6   $
��Left=�6   $��	10,5,10,5q�69   $��1��6L   $��0��6Y   $��Enter count for generete��6~   6�   �� 5   
   -   5        $��startProgramm��5   h   $	��100��6   $��Right=�6   $��5,5,10,5q�69   $��1��6K   $��1��6X   $��Start program��6}   6�   �� 5   
   -   5         ��Name$ startGenButton��5   h   $	��100��6   $��Right=�6   $��5,5,10,5q�69   $��1��6K   $��0��6X   $��	Start gen��6�   6�   5      5      