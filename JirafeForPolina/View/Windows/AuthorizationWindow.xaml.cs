using JirafeForPolina.AppData;
using JirafeForPolina.Model;
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
            try
            {
                Profile currentUser = App.context.Profile.FirstOrDefault(p => p.Login == LoginTb.Text 
                && p.Password == PasswordPb.Password);

                if (currentUser != null)
                {
                    App.currentUser = currentUser;
                    MessageBoxHelper.Information("Авторизация прошла успешно!");
                    


                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBoxHelper.Warning("Пользователь не найден!");
                }

            }
            catch (Exception exception)
            {
                MessageBoxHelper.Error(exception);
            }

        }

        private void RegistrationHL_Click_1(object sender, RoutedEventArgs e)
        {
            Registration1Window registration1Window = new Registration1Window();
            registration1Window.Show();
            Close();
        }
    }
}
