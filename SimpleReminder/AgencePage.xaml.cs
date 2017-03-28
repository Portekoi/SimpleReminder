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
    /// Logique d'interaction pour AgencePage.xaml
    /// </summary>
    public partial class AgencePage : Page
    {
        public AgencePage()
        {
            InitializeComponent();
        }

        private void _backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("RappelPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string nom = _nom.Text;
            string telephone = _telephone.Text;
            string nomContact = _contact.Text;

            Agence agence = new Agence();
            agence.Nom = nom;
            agence.Telephone = telephone;
            agence.NomContact = nomContact;

            Agence.Save(agence);

        }
    }
}
