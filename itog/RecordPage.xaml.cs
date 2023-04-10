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

namespace itog
{
    /// <summary>
    /// Логика взаимодействия для RecordPage.xaml
    /// </summary>
    public partial class RecordPage : Page
    {
        public RecordPage()
        {
            InitializeComponent();
        }

        

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PPEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridRecord.ItemsSource = PPEntities.GetContext().Record.ToList();
            }
        }
        private void DataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (filterBox.Text.Length > 0)
            {
                string str = filterBox.Text;
                DataGridRecord.ItemsSource = PPEntities.GetContext().Record.Where(x => x.Date.ToString().StartsWith(str)).ToList();
            }
            else
            {
                DataGridRecord.ItemsSource = PPEntities.GetContext().Record.ToList();
            }
        }
    }
}
