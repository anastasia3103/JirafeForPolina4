using JirafeForPolina.AppData;
using JirafeForPolina.Model;
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
    /// Логика взаимодействия для AdminActivityPage.xaml
    /// </summary>
    public partial class AdminActivityPage : Page
    {
        private List<Activity> activity = App.context.Activity.ToList();
        private List<Interesting> interesting = App.context.Interesting.ToList();
        public AdminActivityPage()
        {
            InitializeComponent();

            FilterCmb.SelectedValuePath = "Id";
            FilterCmb.DisplayMemberPath = "Title";
            FilterCmb.ItemsSource = interesting;

            InteresCmb.SelectedValuePath = "Id";
            InteresCmb.DisplayMemberPath = "Title";
            InteresCmb.ItemsSource = interesting;

            ActivityLv.ItemsSource = activity;


            interesting.Insert(0, new Interesting() { Title = "Все интересы" });
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddActivityWindow addActivityWindow = new AddActivityWindow();
        
            if (addActivityWindow.ShowDialog() == true)
            {
                ActivityLv.ItemsSource = App.context.Activity.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

            App.context.SaveChanges();
            MessageBoxHelper.Information("Информация успешно изменена!");
        }

        private void DeliteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ActivityLv.SelectedItem == null)
            {
                MessageBoxHelper.Information("Выберите занятие для удаления");
                return;
            }

            Activity selectedActivity = ActivityLv.SelectedItem as Activity;

            var res = MessageBox.Show($"Вы уверены, что хотите удалить?", "Подтверждение", MessageBoxButton.YesNo);

            if (res == MessageBoxResult.Yes)
            {
                App.context.Activity.Remove(selectedActivity);
                App.context.SaveChanges();
                MessageBoxHelper.Information("Занятие далено");
                ActivityLv.ItemsSource = App.context.Activity.ToList();
            }
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
                ActivityLv.ItemsSource = activity;
            }
        }

        private void ActivityLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActivityDetailsGrid.DataContext = ActivityLv.SelectedItem as Activity;

        }

        private void InteresCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
