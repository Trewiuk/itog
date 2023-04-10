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
    /// Логика взаимодействия для AddEditKidPage.xaml
    /// </summary>
    public partial class AddEditKidPage : Page
    {
        private Kid _currentKid = new Kid();
        public AddEditKidPage(Kid SelectKid)
        {
            InitializeComponent();
            if (SelectKid != null)
            {
                _currentKid = SelectKid;
            }
            DataContext = _currentKid;
            CmbCity.ItemsSource = PPEntities.GetContext().City.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_currentKid.Name))

                errors.AppendLine("Заполните данные!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentKid.ID == 0)
            {
                _currentKid.Surname = TxtSurname.Text;
                _currentKid.Name = TxtName.Text;
                _currentKid.Middlename = TxtMiddlename.Text;
                _currentKid.Birthday = TxtBirthday.Text;
                var CurrentCity = CmbCity.SelectedItem as City;
                _currentKid.City = CurrentCity.ID;
                PPEntities.GetContext().Kid.Add(_currentKid);
            }
            try
            {
                PPEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.GoBack();
            }
            catch
            { }
        }

        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        
    }
}
