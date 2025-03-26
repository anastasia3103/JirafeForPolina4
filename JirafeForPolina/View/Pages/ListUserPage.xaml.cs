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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JirafeForPolina.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListUserPage.xaml
    /// </summary>
    public partial class ListUserPage : Page
    {
       public List<Children> children = App.context.Children.ToList();
       public List<User> user = App.context.User.ToList();
        public ListUserPage()
        {
            InitializeComponent();

            UsersLv.ItemsSource = children;


        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            UsersLv.ItemsSource = user.
               Where(p => p.Firstname.Contains(ActivityTb.Text)).ToList();
        }
    }
}
