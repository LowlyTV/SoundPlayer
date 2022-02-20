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
using System.Windows.Threading;
using Microsoft.Win32;


namespace SoundPlayer
{
    /// <summary>
    /// Interaktionslogik für OwnMusic.xaml
    /// </summary>
    public partial class OwnMusic : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();



        public OwnMusic()
        {
            InitializeComponent();

            

        }

        private void OpenDialog()
        {
            

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "MP3 files (*.mp3) | *.mp3 | All files (*.*|*.*";

                if (openFileDialog.ShowDialog() == true)
                {
                    mediaPlayer.Open(new Uri(openFileDialog.FileName));
                    mediaPlayer.Play();
                }
           

        }

        private void UploadMusic(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3) | *.mp3 | All files (*.*|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                mediaPlayer.Play();
                mediaPlayer.Volume = 100;



                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += timer_Ticker;
                timer.Start();
            }
        }


        void timer_Ticker(object sender, EventArgs e)
        {

           

            try
            {
                if (mediaPlayer.Source != null)
                {
                    lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"),
                    mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));

                }
            }
            catch (Exception)
            {
                lblStatus.Content = "Fehler beim Upload der Datei. \nVersuchen Sie es erneut.";

              

            }


           

        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void ZurueckButton(object sender, RoutedEventArgs e)
        {
            var goBack = new MainWindow();
            goBack.Show();

            Close();
        }
    }
}
