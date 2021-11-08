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
using System.IO;

namespace SoundPlayer
{
    /// <summary>
    /// Interaktionslogik für Sounds.xaml
    /// </summary>
    public partial class Sounds : Window
    {
        public Sounds()
        {
            InitializeComponent();
        }

        private void Startseite(object sender, RoutedEventArgs e)
        {
            var home = new MainWindow();
            home.Show();

            Close();
        }

        public async static void AwaitTask(int warten)
        {
            
            await Task.Delay(warten);
        }

        private void ClownTrompete(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.clown_horn);
            sound.Play();
        }

        private void WrongAnswer(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer bassGitarre = new System.Media.SoundPlayer(Resource1.wrongAnswer);
            bassGitarre.Play();
        }

        private void Bells(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.bells);
            
            sound.Play();

            
        }

        private void ChurchBells(object sender, RoutedEventArgs e)
        {
            
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.church_bells_short);
            sound.Play();
        }

        private void BarkingDog(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.dog_barking);
            sound.Play();
        }

        private void Drums(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.drums);
            sound.Play();
        }

        private void GameOver(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.game_over);
            sound.Play();
        }

        private void Pfeife(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.pfeife);
            sound.Play();
        }

        private void RetroGame(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resource1.retro_game);
            sound.Play();
        }

        private void MusikInfo(object sender, RoutedEventArgs e)
        {
            var wnd = new SoundInfo();
            wnd.Show();

            Close();
        }
    }
}
