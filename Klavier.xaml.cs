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
using System.Drawing;

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

            

            

        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            


            switch (e.Key)
            {
                case Key.A:
                    System.Media.SoundPlayer soundC = new System.Media.SoundPlayer(SoundPlayer.Resource1.C);
                    soundC.Play();
                    break;
                case Key.S:
                    System.Media.SoundPlayer soundD = new System.Media.SoundPlayer(SoundPlayer.Resource1.D);
                    soundD.Play();
                    break;
                case Key.D:
                    System.Media.SoundPlayer soundE = new System.Media.SoundPlayer(SoundPlayer.Resource1.E);
                    soundE.Play();
                    break;
                case Key.F:
                    System.Media.SoundPlayer soundF = new System.Media.SoundPlayer(SoundPlayer.Resource1.F);
                    soundF.Play();
                    break;
                case Key.G:
                    System.Media.SoundPlayer soundG = new System.Media.SoundPlayer(SoundPlayer.Resource1.G);
                    soundG.Play();
                    break;
                case Key.H:
                    System.Media.SoundPlayer soundA = new System.Media.SoundPlayer(SoundPlayer.Resource1.A);
                    soundA.Play();
                    break;
                case Key.J:
                    System.Media.SoundPlayer soundB = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
                    soundB.Play();
                    break;
                case Key.K:
                    System.Media.SoundPlayer soundC1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.C1);
                    soundC1.Play();
                    break;
                case Key.L:
                    System.Media.SoundPlayer soundD1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.D1);
                    soundD1.Play();
                    break;
                case Key.OemTilde:
                    System.Media.SoundPlayer soundOe = new System.Media.SoundPlayer(SoundPlayer.Resource1.E1);
                    soundOe.Play();
                    break;
                case Key.Oem7:
                    System.Media.SoundPlayer soundF1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.F1);
                    soundF1.Play();
                    break;
                case Key.W:
                    System.Media.SoundPlayer soundCis = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s);
                    soundCis.Play();
                    break;
                case Key.E:
                    System.Media.SoundPlayer soundDis = new System.Media.SoundPlayer(SoundPlayer.Resource1.D_s);
                    soundDis.Play();
                    break;
                case Key.R:
                    System.Media.SoundPlayer soundFis = new System.Media.SoundPlayer(SoundPlayer.Resource1.F_s);
                    soundFis.Play();
                    break;
                case Key.T:
                    System.Media.SoundPlayer soundGis = new System.Media.SoundPlayer(SoundPlayer.Resource1.G_s);
                    soundGis.Play();
                    break;
                case Key.Z:
                    System.Media.SoundPlayer soundB_oben = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
                    soundB_oben.Play();
                    break;
                case Key.I:
                    System.Media.SoundPlayer soundCis1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s1);
                    soundCis1.Play();
                    break;
                case Key.O:
                    System.Media.SoundPlayer soundDis1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.D_s1);
                    soundDis1.Play();
                    break;
                default:
                    break;
            }
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
