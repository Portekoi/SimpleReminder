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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            List<Rappel> lstRappel = new List<Rappel>();
           lstRappel.Add(new Rappel { Agence = new Agence(), DateHeure = DateTime.Now, Montant = 100.25F, NomClient="Test", NumDossier="1234" });
           lstRappel.Add(new Rappel { Agence = new Agence(), DateHeure = DateTime.Now, Montant = 100.25F, NomClient="Test", NumDossier="1234" });
      

           ListeRappels.ItemsSource = lstRappel;
           
        }

        

        private void editionAgence_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("RappelPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListeRappels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
