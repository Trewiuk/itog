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
    /// Логика взаимодействия для HelloPageAdmin.xaml
    /// </summary>
    public partial class HelloPageAdmin : Page
    {
        public HelloPageAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void Button_Click_Record(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RecordPageAdmin());
        }

        private void Button_Click_User(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPage());
        }

        private void Button_Click_Kid(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KidPageAdmin());
        }
    }
}
