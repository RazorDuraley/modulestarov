using System;
using System.Linq;
using System.Windows;

namespace WpfAppTarovPr2
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void Button_Check_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

      
            if (string.IsNullOrWhiteSpace(input))
            {
                ResultTextBlock.Text = "Пожалуйста, введите элементы массива.";
                return;
            }

            try
            {
         
                var numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

  
                for (int i = 1; i < numbers.Length; i++)
                {
                    if ((numbers[i] % 2) == (numbers[i - 1] % 2))
                    {
                        ResultTextBlock.Text = $"Нарушение на индексе: {i}";
                        return;
                    }
                }

                ResultTextBlock.Text = "0 (Чередуются)";
            }
            catch (FormatException)
            {
                ResultTextBlock.Text = "Ошибка: пожалуйста, введите корректные целые числа.";
            }
        }
    }
}
