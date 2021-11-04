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

        

        public async static void virtualButtonPressAsync2(Button button1)
        {
            
                button1.Background = new SolidColorBrush(Colors.LightSkyBlue);
                await Task.Delay(300);
                button1.Background = new SolidColorBrush(Colors.White);
               
            
        }

        public async static void virtualButtonPressAsync(Button button1)
        {
            button1.Background = new SolidColorBrush(Colors.LightSkyBlue);
            await Task.Delay(300);
            button1.Background = new SolidColorBrush(Colors.Black);
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            


            switch (e.Key)
            {
                case Key.A:
                    virtualButtonPressAsync2(buttonc);
                    System.Media.SoundPlayer soundC = new System.Media.SoundPlayer(SoundPlayer.Resource1.C);
                    soundC.Play();
                    break;
                case Key.S:
                    virtualButtonPressAsync2(buttond);
                    System.Media.SoundPlayer soundD = new System.Media.SoundPlayer(SoundPlayer.Resource1.D);
                    soundD.Play();
                    break;
                case Key.D:
                    virtualButtonPressAsync2(buttone);
                    System.Media.SoundPlayer soundE = new System.Media.SoundPlayer(SoundPlayer.Resource1.E);
                    soundE.Play();
                    break;
                case Key.F:
                    virtualButtonPressAsync2(buttonf);
                    System.Media.SoundPlayer soundF = new System.Media.SoundPlayer(SoundPlayer.Resource1.F);
                    soundF.Play();
                    break;
                case Key.G:
                    virtualButtonPressAsync2(buttong);
                    System.Media.SoundPlayer soundG = new System.Media.SoundPlayer(SoundPlayer.Resource1.G);
                    soundG.Play();
                    break;
                case Key.H:
                    virtualButtonPressAsync2(buttona);
                    System.Media.SoundPlayer soundA = new System.Media.SoundPlayer(SoundPlayer.Resource1.A);
                    soundA.Play();
                    break;
                case Key.J:
                    virtualButtonPressAsync2(buttonb);
                    System.Media.SoundPlayer soundB = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
                    soundB.Play();
                    break;
                case Key.K:
                    virtualButtonPressAsync2(buttonc1);
                    System.Media.SoundPlayer soundC1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.C1);
                    soundC1.Play();
                    break;
                case Key.L:
                    virtualButtonPressAsync2(buttond1);
                    System.Media.SoundPlayer soundD1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.D1);
                    soundD1.Play();
                    break;
                case Key.OemTilde:
                    virtualButtonPressAsync2(buttone1);
                    System.Media.SoundPlayer soundOe = new System.Media.SoundPlayer(SoundPlayer.Resource1.E1);
                    soundOe.Play();
                    break;
                case Key.Oem7:
                    virtualButtonPressAsync2(buttonf1);
                    System.Media.SoundPlayer soundF1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.F1);
                    soundF1.Play();
                    break;
                case Key.W:
                    virtualButtonPressAsync(buttoncis);
                    System.Media.SoundPlayer soundCis = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s);
                    soundCis.Play();
                    break;
                case Key.E:
                    virtualButtonPressAsync(buttondis);
                    System.Media.SoundPlayer soundDis = new System.Media.SoundPlayer(SoundPlayer.Resource1.D_s);
                    soundDis.Play();
                    break;
                case Key.R:
                    virtualButtonPressAsync(buttonfis);
                    System.Media.SoundPlayer soundFis = new System.Media.SoundPlayer(SoundPlayer.Resource1.F_s);
                    soundFis.Play();
                    break;
                case Key.T:
                    virtualButtonPressAsync(buttongis);
                    System.Media.SoundPlayer soundGis = new System.Media.SoundPlayer(SoundPlayer.Resource1.G_s);
                    soundGis.Play();
                    break;
                case Key.Z:
                    virtualButtonPressAsync(buttonb2);
                    System.Media.SoundPlayer soundB_oben = new System.Media.SoundPlayer(SoundPlayer.Resource1.B);
                    soundB_oben.Play();
                    break;
                case Key.I:
                    virtualButtonPressAsync(buttoncis1);
                    System.Media.SoundPlayer soundCis1 = new System.Media.SoundPlayer(SoundPlayer.Resource1.C_s1);
                    soundCis1.Play();
                    break;
                case Key.O:
                    virtualButtonPressAsync(buttondis1);
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

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }

        private void Hilfe_Menue_Klavier(object sender, RoutedEventArgs e)
        {

            

            var wnd = new Klavier_Hilfe();
            wnd.Show();

            Close();
        }

        private void Startseite(object sender, RoutedEventArgs e)
        {
            var wnd = new MainWindow();
            wnd.Show();

            Close();
        }

       
        
    }
}
