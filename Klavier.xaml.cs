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
using System.Media;
using System.Runtime;

namespace SoundPlayer
{
    /// <summary>
    /// Interaktionslogik für Klavier.xaml
    /// </summary>
    public partial class Klavier : Window
    {
        public Klavier()
        {
            InitializeComponent();

            Environment.SpecialFolder mymusic = new Environment.SpecialFolder();

            String path = "/MusicNotes/C.wav";

        }

        private void Button_Click(object sender, RoutedEventArgs e) //C
        {

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.C);
            sound.Play();
           
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e) //C1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.C1);
            sound.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //D
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.D);
            sound.Play();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //E
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.E);
            sound.Play();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //F
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.F);
            sound.Play();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //G
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.G);
            sound.Play();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //A
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.A);
            sound.Play();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //B
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
            sound.Play();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) //D1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.D1);
            sound.Play();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //Cis
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s);
            sound.Play();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //Dis
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.D_s);
            sound.Play();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) //Fis
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.F_s);
            sound.Play();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //Gis
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.G_s);
            sound.Play();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) //B
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
            sound.Play();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //Cis1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s1);
            sound.Play();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) //E1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.E1);
            sound.Play();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e) //F1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.F1);
            sound.Play();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e) //Dis1
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(SoundPlayer.Resource1.D_s1);
            sound.Play();

        }
    }
}
