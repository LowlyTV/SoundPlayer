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
using System.Windows.Shapes;

namespace SoundPlayer
{
    /// <summary>
    /// Interaktionslogik für Klavier_Hilfe.xaml
    /// </summary>
    public partial class Klavier_Hilfe : Window
    {
        public Klavier_Hilfe()
        {
            InitializeComponent();
        }

        private void Zurueck_zum_Klavier(object sender, RoutedEventArgs e)
        {

            

            var wmd = new Klavier();
            wmd.Show();

            Close();


        }
    }
}
