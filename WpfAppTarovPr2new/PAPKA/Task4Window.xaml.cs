



using System;
using System.Linq;
using System.Windows;

namespace WpfAppTarovPr2.PAPKA
{
    public partial class Task4Window : Window
    {
        public Task4Window()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
           
                string input = InputArrayTextBox.Text;
                int[] array = input.Split(',')
                                   .Select(x => int.Parse(x.Trim()))
                                   .ToArray();

          
                int max = array.Max();

           
                (int index1, int index2) = FindClosestSumPair(array, max);

               
                if (index1 != -1 && index2 != -1)
                {
                    int temp = array[index1];
                    array[index1] = array[index2];
                    array[index2] = temp;
                }

              
                ResultTextBox.Text = string.Join(", ", array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public static void ShowNewWindow()
        {
            Task4Window window = new Task4Window();
            window.Show();
        }
        private (int, int) FindClosestSumPair(int[] array, int targetSum)
        {
            int closestSum = int.MinValue;
            int index1 = -1, index2 = -1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (sum > closestSum && sum <= targetSum)
                    {
                        closestSum = sum;
                        index1 = i;
                        index2 = j;
                    }
                }
            }

            return (index1, index2);
        }
    }
}
