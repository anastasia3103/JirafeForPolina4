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
    /// Логика взаимодействия для ActiviryPage.xaml
    /// </summary>
    public partial class ActiviryPage : Page
    {
        private List<Activity> activity = App.context.Activity.ToList();
        private List<Interesting> interesting = App.context.Interesting.ToList();

        public ActiviryPage()
        {
            InitializeComponent();


            FilterCmb.SelectedValuePath = "Id";
            FilterCmb.DisplayMemberPath = "Title";
            FilterCmb.ItemsSource = interesting;

            ActivityLv.ItemsSource = activity;


            interesting.Insert(0, new Interesting() { Title = "Все интересы" });
        }

        private void RecordBtn_Click(object sender, RoutedEventArgs e)
        {

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
        }

        private void ActivityLv_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ActivityDetailsGrid.DataContext = ActivityLv.SelectedItem as Activity;

        }
    }
}
