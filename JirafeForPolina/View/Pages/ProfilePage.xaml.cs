using JirafeForPolina.AppData;
using JirafeForPolina.Model;
using JirafeForPolina.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {


        public ProfilePage()
        {
            InitializeComponent();

            ChildLv.ItemsSource = App.context.Children.
                Where(u => u.User.Id == App.currentUser.Id).ToList();
        }

        private void EditTb_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();
            MessageBoxHelper.Information("Информация успешно изменена!");
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            MainWindow mainWindow = new MainWindow();
            authorizationWindow.Show();
            mainWindow.Close();
        }

        private void ChildLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddChildBtn_Click(object sender, RoutedEventArgs e)
        {
            AddChildrenWindow addChildrenWindow = new AddChildrenWindow();
            addChildrenWindow.ShowDialog();
        }
    }
}
