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
using System.Media;


namespace SoundPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Sound1()
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\Users\Simon\Downloads\test2.wav");
            soundPlayer.Play();



        }

        private void Sound2()
        {
           

        }

        private void BtnSound1_Click(object sender, RoutedEventArgs e)
        {
            Sound1();
        }

        private void BtnSound2_Click(object sender, RoutedEventArgs e)
        {
            Sound2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var wnd = new Klavier();
            wnd.Show();
        }

        private void BtnSound2_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
