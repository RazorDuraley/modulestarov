using System;
using System.Windows;

namespace WpfAppTarovPr2
{
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

            // Разделяем строку на слова, учитывая пробелы
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (string word in words)
            {
                // Считаем количество букв "А" в слове
                int aCount = 0;
                foreach (char c in word)
                {
                    if (c == 'а' || c == 'А') // Учитываем как строчные, так и заглавные буквы
                    {
                        aCount++;
                    }
                }

                // Проверяем, содержит ли слово ровно три буквы "А"
                if (aCount == 3)
                {
                    count++;
                }
            }

            ResultTextBlock.Text = $"Количество слов, содержащих ровно три буквы 'А': {count}";
        }
    }
}
