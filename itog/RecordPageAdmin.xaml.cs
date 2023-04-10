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
    /// Логика взаимодействия для RecordPageAdmin.xaml
    /// </summary>
    public partial class RecordPageAdmin : Page
    {
        public RecordPageAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditRecordPage(null));
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

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            var RecordForRemoving = DataGridRecord.SelectedItems.Cast<Record>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {RecordForRemoving.Count()} элементов ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PPEntities.GetContext().Record.RemoveRange(RecordForRemoving);
                    PPEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены! ");
                    DataGridRecord.ItemsSource = PPEntities.GetContext().Record.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditRecordPage((sender as Button).DataContext as Record));
        }

        
    }
}
