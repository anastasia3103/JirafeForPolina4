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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationHL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegistrationHL_Click_1(object sender, RoutedEventArgs e)
        {
            Registration1Window registration1Window = new Registration1Window();
            registration1Window.Show();
            Close();
        }
    }
}
