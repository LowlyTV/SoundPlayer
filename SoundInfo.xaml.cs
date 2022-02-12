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
using System.Runtime.InteropServices;

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

            

            var url = "https://mixkit.co/";

            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
                
            }


        }

        private void Zurück(object sender, RoutedEventArgs e)
        {
            var goback = new Sounds();
            goback.Show();

            Close();
        }

        
    }
}
