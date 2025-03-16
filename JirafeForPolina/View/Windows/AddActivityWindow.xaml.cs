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
    /// Логика взаимодействия для AddActivityWindow.xaml
    /// </summary>
    public partial class AddActivityWindow : Window
    {
        public AddActivityWindow()
        {
            InitializeComponent();

            ActivityCategoryCmb.SelectedValuePath = "Id";
            ActivityCategoryCmb.DisplayMemberPath = "Title";
            ActivityCategoryCmb.ItemsSource = App.context.Interesting.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {

            Activity activity = new Activity()
            {
                Title = ActivityNameTb.Text,
                Date = (DateTime)ActivityDp.SelectedDate,
                Time = ActivityTimeTb.Text,
                Description = ActivityDescriptionTb.Text,
                Interesting = ActivityCategoryCmb.SelectedItem as Interesting

            };


            App.context.Activity.Add(activity);
            App.context.SaveChanges();
            MessageBoxHelper.Information("Занятие добавлено!");

            ActivityNameTb.Text = "";
            ActivityDescriptionTb.Text = "";
            ActivityTimeTb.Text = "";
            ActivityDp.Text = "";
            ActivityCategoryCmb.Text = "";
        }
    }
}
