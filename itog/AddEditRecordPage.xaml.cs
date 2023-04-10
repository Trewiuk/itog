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
    /// Логика взаимодействия для AddEditRecordPage.xaml
    /// </summary>
    public partial class AddEditRecordPage : Page
    {
        private Record _currentRecord = new Record();
        public AddEditRecordPage(Record SelectRecord)
        {
            InitializeComponent();
            if (SelectRecord != null)
            {
                _currentRecord = SelectRecord;
            }
            DataContext = _currentRecord;
            CmbCabinet.ItemsSource = PPEntities.GetContext().Cabinet.ToList();
            CmbUser.ItemsSource = PPEntities.GetContext().User.ToList();
            CmbKid.ItemsSource = PPEntities.GetContext().Kid.ToList();
        }
        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();   
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentRecord.Date))

                errors.AppendLine("Заполните данные!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentRecord.ID == 0)
            {
                _currentRecord.Date = TxtDate.Text;
                _currentRecord.Time_Start = TxtTime.Text;
                PPEntities.GetContext().Record.Add(_currentRecord);
                var CurrentCabinet = CmbCabinet.SelectedItem as Cabinet;
                var CurrentUser = CmbUser.SelectedItem as User;
                var CurrentKid = CmbKid.SelectedItem as Kid;
                _currentRecord.Cabinet = CurrentCabinet;
                _currentRecord.User = CurrentUser;
                _currentRecord.Kid = CurrentKid;
                PPEntities.GetContext().Record.Add(_currentRecord);
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

        
    }
}
