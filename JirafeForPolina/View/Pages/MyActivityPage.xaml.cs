using JirafeForPolina.AppData;
using JirafeForPolina.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    /// Логика взаимодействия для MyActivityPage.xaml
    /// </summary>
    public partial class MyActivityPage : Page
    {

        private List<Activity> activity = App.context.Activity.ToList();
        private List<Interesting> interesting = App.context.Interesting.ToList();
        public MyActivityPage()
        {
            InitializeComponent();

            FilterCmb.SelectedValuePath = "Id";
            FilterCmb.DisplayMemberPath = "Title";
            FilterCmb.ItemsSource = interesting;


            ActivityLv.ItemsSource = App.context.RecordOnActivity.
                Where( u => u.User.Id == App.currentUser.Id ).ToList();



            interesting.Insert(0, new Interesting() { Title = "Все интересы" });



        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            ActivityLv.ItemsSource = App.context.Activity.
                Where(a => a.Title.Contains(ActivityTb.Text)).ToList();
        }

        private void FilterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            Interesting interesting = FilterCmb.SelectedItem as Interesting;
            if (FilterCmb.SelectedIndex != 0)
            {
                ActivityLv.ItemsSource = activity.Where(x => x.Interesting.Id == interesting.Id);

            }
            else
            {
                ActivityLv.ItemsSource = App.context.RecordOnActivity.
                Where(u => u.User.Id == App.currentUser.Id).ToList(); ;
            }
        }

        private void ActivityLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActivityDetailsGrid.DataContext = ActivityLv.SelectedItem as RecordOnActivity;
        }


        private void OtmenaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ActivityLv.SelectedItem == null)
            {
                MessageBoxHelper.Information("Выберите занятие для отмены");
                return;
            }

            RecordOnActivity selectedActivity = ActivityLv.SelectedItem as RecordOnActivity;

            var res = MessageBox.Show($"Вы уверены, что хотите удалить?", 
                "Подтверждение", MessageBoxButton.YesNo);

            if (res == MessageBoxResult.Yes)
            {
                App.context.RecordOnActivity.Remove(selectedActivity);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Удалено");
                ActivityLv.ItemsSource = App.context.RecordOnActivity.
                Where(u => u.User.Id == App.currentUser.Id).ToList();
            }
        }
    }
}
