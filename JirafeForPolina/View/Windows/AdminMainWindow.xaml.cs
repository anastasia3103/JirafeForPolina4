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
using System.Windows.Threading;

namespace JirafeForPolina.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();



        }

        private void ActivityBtnHl_Click(object sender, RoutedEventArgs e)
        {

            FrameHelper.MainAdminFrame = MainAdminFrame;
            FrameHelper.MainAdminFrame.Navigate(new View.Pages.AdminActivityPage());
        }

        private void TicketsHl_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainAdminFrame.Navigate(new View.Pages.TicketsPage());
        }


        private void UserListHl_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.MainAdminFrame.Navigate(new View.Pages.ListUserPage());
        }
    }
}
