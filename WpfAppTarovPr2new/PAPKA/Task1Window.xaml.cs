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
            if (int.TryParse(InputTextBox.Text, out int year) && year > 0)
            {
       
                bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        
                if (isLeapYear)
                {
                    ResultTextBlock.Text = $"Год {year} является високосным и содержит 366 дней.";
                }
                else
                {
                    ResultTextBlock.Text = $"Год {year} является обычным и содержит 365 дней.";
                }
            }
            else
            {
                MessageBox.Show("Введите корректное положительное целое число!");
            }
        }
    }
}
