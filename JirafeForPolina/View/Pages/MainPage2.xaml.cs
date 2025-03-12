using JirafeForPolina.AppData;
using JirafeForPolina.View.Windows;
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

namespace JirafeForPolina.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage2.xaml
    /// </summary>
    public partial class MainPage2 : Page
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void TicketsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new TicketsPage());
        }

        private void EvantsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainUserFrame.Navigate(new ActiviryPage());
        }
    }
}
