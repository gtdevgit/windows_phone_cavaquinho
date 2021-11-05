using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Cavac2.Modele;


namespace Cavac2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtPrecedent_Click(object sender, RoutedEventArgs e)
        {
            // ((this.DataContext) as Global).Precedent();
        }

        private void BtSuivant_Click(object sender, RoutedEventArgs e)
        {
            //((this.DataContext) as Global).Suivant();
        }

        private void ListeAccords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //
        }

    }
}