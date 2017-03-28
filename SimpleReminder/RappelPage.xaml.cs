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

namespace SimpleReminder
{
    /// <summary>
    /// Logique d'interaction pour Rappel.xaml
    /// </summary>
    public partial class RappelPage : Page
    {
        public RappelPage()
        {
            InitializeComponent();
        }

        private void _navigation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("AgencePage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
