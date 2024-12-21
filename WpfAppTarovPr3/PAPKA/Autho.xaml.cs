using System.Windows;
using System.Windows.Controls;
using WpfAppTarovPr2.PAPKA;

namespace AutoservicesRul.Pages // Убедитесь, что пространство имен совпадает с пространством имен в XAML
{
    public partial class Auto : Page // Замените Window на Page, если вы используете Page в XAML
    {
        public Auto() // Добавьте конструктор
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client(null));
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Войти' нажата!");
        }
    }
}
