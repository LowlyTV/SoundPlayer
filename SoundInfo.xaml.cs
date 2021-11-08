using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
using System.Windows.Navigation;


namespace SoundPlayer
{
    /// <summary>
    /// Interaktionslogik für SoundInfo.xaml
    /// </summary>
    public partial class SoundInfo : Window
    {
        public SoundInfo()
        {
            InitializeComponent();
        }

        private void OpenWebsite(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("This Button doesn't work right now");


        }

        private void Zurück(object sender, RoutedEventArgs e)
        {
            var goback = new Sounds();
            goback.Show();

            Close();
        }
    }
}
