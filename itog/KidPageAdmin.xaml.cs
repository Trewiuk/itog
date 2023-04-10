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
    /// Логика взаимодействия для KidPageAdmin.xaml
    /// </summary>
    public partial class KidPageAdmin : Page
    {
        public KidPageAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            var KidForRemoving = DataGridKid.SelectedItems.Cast<Kid>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {KidForRemoving.Count()} элементов ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PPEntities.GetContext().Kid.RemoveRange(KidForRemoving);
                    PPEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены! ");
                    DataGridKid.ItemsSource = PPEntities.GetContext().Kid.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditKidPage(null));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PPEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridKid.ItemsSource = PPEntities.GetContext().Kid.ToList();
            }
        }

        private void DataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditKidPage((sender as Button).DataContext as Kid));
        }

        private void filterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (filterBox.Text.Length > 0)
            {
                string str = filterBox.Text;
                DataGridKid.ItemsSource = PPEntities.GetContext().Kid.Where(x => x.Surname.ToString().StartsWith(str)).ToList();
            }
            else
            {
                DataGridKid.ItemsSource = PPEntities.GetContext().Kid.ToList();
            }
        }
    }
}
