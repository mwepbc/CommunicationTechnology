using CommunicationTechnology.Pages;
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

namespace CommunicationTechnology
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //метод для инициализации всех компонентов в странице
            InitializeComponent();

            //Чтобы при запуске приложения загрузить в MainFrame страницу личного кабинета
            //используем метод Navigate
            MainFrame.Navigate(new PersonalPage());

            //Проблема - cs файл может не увидеть вашу страницы в папке Pages
            //для решения достаточно в начале странице добавить ещё один using
            //с указанием вашей папки в проекте

            //достаточно просто правильно прописать название страницы и рефакторинг
            //сам пропишет нужные строчки
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //при нажатии на кнопку 'назад' будет производится проверка
            //а можно ли вообще в фрейме вернуться на предыдущую страницу
            //если да, то фрейм перебрасывает нас назад
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            //соответственно, если в фрейме нет предыдущих страниц, то кнопка
            //назад попросту не отображается
            if (!MainFrame.CanGoBack)
            {
                BackButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                BackButton.Visibility = Visibility.Visible;
            }
        }
    }
}
