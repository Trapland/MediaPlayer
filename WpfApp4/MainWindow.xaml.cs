using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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

        private void b_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                media.Source = new Uri(ofd.FileName);
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Play;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Pause;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Stop;
        }

        private void s1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (s1.Maximum != media.NaturalDuration.TimeSpan.TotalSeconds)
                s1.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            media.Position = TimeSpan.FromSeconds(s1.Value);
        }

        private void s1_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {

        }
    }
}
