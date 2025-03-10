using JirafeForPolina.AppData;
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
using System.Windows.Shapes;

namespace JirafeForPolina.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameHelper.MainUserFrame = MainUserFrame;
            MainUserFrame.Navigate(new View.Pages.MainPage2());
        }

        private void MainHL_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new View.Pages.MainPage2());
        }

        private void CatalogHL_Click(object sender, RoutedEventArgs e)
        {

            MainUserFrame.Navigate(new View.Pages.ActiviryPage());
        }

        private void ProfileHL_Click(object sender, RoutedEventArgs e)
        {
            MainUserFrame.Navigate(new View.Pages.ProfilePage());
        }
    }
}
