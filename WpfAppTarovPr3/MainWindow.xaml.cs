using AutoservicesRul.Pages;
using System;
using System.Windows;
using WpfAppTarovPr2.PAPKA;

namespace WpfAppTarovPr2
{
    public partial class MainWindow : Window
    {

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {
         if (FrmMain.CanGoBack)
                btnBack.Visibility = Visibility.Visible;
         else 
                btnBack.Visibility = Visibility.Hidden;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
       FrmMain.GoBack();
        }

       
            public MainWindow()
            {
                InitializeComponent();
                FrmMain.Navigate(new Auto());
            }
        

   

        private void Button_Task1_Click(object sender, RoutedEventArgs e)
        {
            Task1Window task1Window = new Task1Window();
            task1Window.ShowDialog();
        }

        private void Button_Task2_Click(object sender, RoutedEventArgs e) {
            Task2Window task2Window = new Task2Window();
            task2Window.ShowDialog();
        }
        private void Button_Task3_Click(object sender, RoutedEventArgs e)
        {
            Task3Window task3Window = new Task3Window();
            task3Window.ShowDialog();
        }
        private void Button_Task4_Click(object sender, RoutedEventArgs e)
        {
            Task4Window task4Window = new Task4Window();
            task4Window.ShowDialog();
        }

        private void Button_Task5_Click(object sender, RoutedEventArgs e)
        {
            Task5Window task5Window = new Task5Window();
            task5Window.ShowDialog();
        }

        private void OpenTask4Window_Click(object sender, RoutedEventArgs e)
        {
            Task4Window.ShowNewWindow();
        }

    }
}

