   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:SystemProgramming_HW_4.DecreasingValue.View+SystemProgramming_HW_4.DecreasingValue.View  5   	   <    6SystemProgramming_HW_4.DecreasingValue.View.Decreasing   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:SystemProgramming_HW_4.DecreasingValue.View     5   	     � Title$  
Decreasing��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.3* �6   6,   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6   $��Right=�6-   $	��Top=�6I   $��
0,20,130,0q�6a   $��Max 3 thread��6u   $	��100��6�   $��25��6�   6�   �� 5   
   $��0��6   $��1��6   $��Right=�6-   $	��Top=�6I   $��	0,20,80,0q�6a   $��Max 3 thread��6t   $	��100��6�   $��25��6�   6�   �� 5   
   -   5        $��startButton1��5   h   $��1��6   $
��Left=�6"   $	��Top=�6=   $��	10,20,0,0q�6U   $	��150��6�   $��25��6�   $��Decreasing one��6�   6�   �� 5   
   -   5        $��startButton5��5   g   $��0��6   $
��Left=�6!   $	��Top=�6<   $��	10,20,0,0q�6T   $	��150��6�   $��25��6�   $��Decreasing five��6�   6�   �� 5   
   $��1��6   $��1��6    $��Before��60   $��5,0,5,5q�6A   .��5      �� -   5         ��Name$ before1StackPanel��5       �� Orientation$ 
Horizontal=�65   .+�5      �� -   5         ��Name$ 	Before1_1��5      $	��124��6-   6=   �� 5      -   5        $ 	Before2_1��5      $	��124��6-   6;   �� 5      -   5        $ 	Before3_1��5      $	��124��6-   6<   5      5      �� 5   
   $��2��6   $��1��6    $��After��60   $��5,0,5,5q�6@   .��5      �� -   5        $ After1StackPanel��5      $ 
Horizontal=�64   .+�5       �� -   5        $ After1_1��5       $	��124��6,   6<   �� 5!      -	   5        $ After2_1��5!      $	��124��6,   6:   �� 5"      -
   5        $ After3_1��5"      $	��124��6,   6;   5#      5$      �� 5%   
   $��1��6   $��0��6    $��Before��60   $��5,0,5,5q�6A   .��5&      �� -   5        $ before5StackPanel��5&      $ 
Horizontal=�65   .+�5'      �� -   5        $ 	Before1_5��5'      $	��124��6-   6=   �� 5(      -   5        $ 	Before2_5��5(      $	��124��6-   6;   �� 5)      -   5        $ 	Before3_5��5)      $	��124��6-   6<   5*      5+      �� 5,   
   $��2��6   $��0��6    $��After��60   $��5,0,5,5q�6@   .��5-      �� -   5        $ After5StackPanel��5-      $ 
Horizontal=�64   .+�5.      �� -   5        $ After1_5��5.      $	��124��6,   6<   �� 5/      -   5        $ After2_5��5/      $	��124��6,   6:   �� 50      -   5        $ After3_5��50      $	��124��6,   6;   51      52      53      54      