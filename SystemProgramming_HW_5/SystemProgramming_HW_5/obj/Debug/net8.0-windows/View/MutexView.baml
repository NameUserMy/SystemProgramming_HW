   M S B A M L   `   `   `  ����Q  MSystemProgramming_HW_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SystemProgramming_HW_5.ViewSystemProgramming_HW_5.View  5      +    %SystemProgramming_HW_5.View.MutexView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SystemProgramming_HW_5.View     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      6   .+�5   
   �� $��0��6   $��0��6   $*��$Enter Count number (default 5000000)��6.   6_   �� 5   
   -   5         ��Name$ countTextBox��5   @   $��0��6   $��1��6   $��5,5,5,5q�6/   6V   �� 5   
   -   5        $��0��5      $��2��6   $��5,5,5,5q�6/   $��Start programm��6@   6p   �� 5   
   -   5         ��Name$ randomListViev��5   -   $��1��6   $��0��6   
���������6X   �� *	GetRandom+6y   �� 5   
   -   5        $ simple��5   -   $��1��6   $��1��6   
���������6P   �� *	GetSimple+6q   �� 5   
   -   5        $ seven��5   -   $��1��6   $��2��6   
���������6O   �� *GetSevenSimple+6u   �� 5   
   -   5         ��Name$ 
randomList��5   A   $��2��6   $��0��6    $��5,5,5,5q�60   ��6U   �� *GetRandomList+�� 5   
   -   5        $ 
simpleList��5   A   $��2��6   $��1��6    $��5,5,5,5q�60   ��6U   �� *GetSimpleList+�� 5   
   -   5        $ 	sevenList��5   A   $��2��6   $��2��6    $��5,5,5,5q�60   ��6T   �� *GetSevenList+5      5       