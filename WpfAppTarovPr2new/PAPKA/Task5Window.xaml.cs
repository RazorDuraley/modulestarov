using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppTarovPr2.PAPKA
{
    public partial class Task5Window : Window
    {
        public Task5Window()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем размеры массива
                int rows = int.Parse(RowsTextBox.Text);
                int columns = int.Parse(ColumnsTextBox.Text);

                // Генерируем массив
                int[,] array = GenerateArray(rows, columns);
                DisplayArray(array, GeneratedArrayDataGrid);

                // Сортируем массив
                int[] flatArray = array.Cast<int>().ToArray();
                Array.Sort(flatArray);

                // Отображаем отсортированный массив по возрастанию
                DisplaySortedArray(flatArray, SortedAscendingDataGrid);

                // Отображаем отсортированный массив по убыванию
                Array.Reverse(flatArray);
                DisplaySortedArray(flatArray, SortedDescendingDataGrid);

                // Находим максимальный и минимальный элементы
                int min = flatArray.First();
                int max = flatArray.Last();
                MinMaxTextBlock.Text = $"Минимум: {min}, Максимум: {max}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private int[,] GenerateArray(int rows, int columns)
        {
            Random random = new Random();
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-10, 11); // Генерация числа от -10 до 10
                }
            }

            return array;
        }

        private void DisplayArray(int[,] array, DataGrid dataGrid)
        {
            var data = new System.Collections.Generic.List<object>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var row = new object[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row[j] = array[i, j];
                }
                data.Add(row);
            }

            dataGrid.ItemsSource = data;
        }

        private void DisplaySortedArray(int[] array, DataGrid dataGrid)
        {
            var data = new System.Collections.Generic.List<object>();

            for (int i = 0; i < array.Length; i++)
            {
                data.Add(new object[] { array[i] });
            }

            dataGrid.ItemsSource = data;
        }
    }
}
