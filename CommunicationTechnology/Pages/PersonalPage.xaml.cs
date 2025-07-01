using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunicationTechnology.Pages
{
    /// <summary>
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        public PersonalPage()
        {
            InitializeComponent();
        }

        private void TariffButton_Click(object sender, RoutedEventArgs e)
        {
            //this - указывает на текущий элемент, в котором происходит событие
            //NavigationService, собственно, вызывает сервис навигации по страницам
            //метод Navigate перебрасывает на указанную страницу
            this.NavigationService.Navigate(new TariffPage());
        }

        private void CostButton_Click(object sender, RoutedEventArgs e)
        {
            //класс MessageBox отвечает за выполнение окна сообщения
            //метод Show отображает окно с сообщением, указываемым в скобках
            MessageBox.Show("Страница в разработке");
        }

        private void ServicesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Страница в разработке");
        }

        private void SupportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Страница в разработке");
        }
    }
}
