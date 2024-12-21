using System;
using System.Windows;

namespace WpfAppTarovPr2
{
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(InputTextBox.Text, out double number))
            {
                // Ваш код расчета здесь.  Пример:
                double result = number * 2; // Замените на нужную логику
                ResultTextBlock.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }
    }
}