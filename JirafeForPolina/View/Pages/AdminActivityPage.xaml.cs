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
        public AdminActivityPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddActivityWindow addActivityWindow = new AddActivityWindow();
            addActivityWindow.ShowDialog();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeliteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FilterCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ActivityLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
