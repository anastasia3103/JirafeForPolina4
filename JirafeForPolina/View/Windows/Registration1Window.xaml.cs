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
    /// Логика взаимодействия для Registration1Window.xaml
    /// </summary>
    public partial class Registration1Window : Window
    {
        public Registration1Window()
        {
            InitializeComponent();
        }

        private void EntryHL_Click(object sender, RoutedEventArgs e)
        {

            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
