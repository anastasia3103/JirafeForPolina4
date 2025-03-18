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
    /// Логика взаимодействия для AddChildrenWindow.xaml
    /// </summary>
    public partial class AddChildrenWindow : Window
    {
        public AddChildrenWindow()
        {
            InitializeComponent();
        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Children children = new Children()
            {
                Name = NameTb.Text,
                Firstname = FirstnameTb.Text,
                Middlename = MiddlenameTb.Text,
                DateOfBirth = (DateTime)DateOfBirthDp.SelectedDate,
                Features = DescriptionTb.Text,
                IdUser = App.currentUser.Id

            };

            App.context.Children.Add(children);
            App.context.SaveChanges();
            MessageBoxHelper.Information("Ребенок добавлен!");

            NameTb.Text = "";
            FirstnameTb.Text = "";
            MiddlenameTb.Text = "";
            DateOfBirthDp.Text = "";
            DescriptionTb.Text = "";
        }

    }
}
