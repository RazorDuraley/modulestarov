   M S B A M L   `   `   `  ����  WpfAppTarovPr2&     WpfAppTarovPr2.PAPKA.Task5Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Task 5��5   	   $	��400��6   $	��600��6%   .��5      �� $��10q�6   .+�5   
   �� $9��3Введите количество строк (N):��6   �� 5   
   -   5         ��Name$ RowsTextBox��5      $��0,0,0,10q�6'   �� 5	   
   $?��9Введите количество столбцов (M):��6   �� 5
   
   -   5        $ ColumnsTextBox��5
      $��0,0,0,10q�6*   �� 5   
   -   5        $-��'Сгенерировать массив��5      $��0,0,0,10q�6M   �� 5   
   $2��,Сгенерированный массив:��6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GeneratedArrayDataGrid��5         AutoGenerateColumns . $��0,0,0,10q�6N   �� 5   
   $N��HОтсортированный по возрастанию массив:��6     5   
   -   5        $ SortedAscendingDataGrid��5       . $��0,0,0,10q�6O   �� 5   
   $H��BОтсортированный по убыванию массив:��6     5   
   -   5        $ SortedDescendingDataGrid��5       . $��0,0,0,10q�6P   �� 5   
   -   5         ��Name$ MinMaxTextBlock��5      $��0,10,0,0q�6-   5      5      