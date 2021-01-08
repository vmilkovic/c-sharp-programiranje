using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Stoperica {
   
    public partial class MainWindow : Window {
        private DispatcherTimer timer;
        private double vrijeme;
        private bool pokrenuto;

        public MainWindow() {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += PromjenaVremena;
        }

        private void PromjenaVremena(object sender, EventArgs e) {
            vrijeme += 0.1;
            lblVrijeme.Content = decimal.Round((decimal)vrijeme, 1).ToString();
        }

        private void btnStartStop_Click(object sender, RoutedEventArgs e) {
            if(pokrenuto) {
                timer.Stop();
            } else {
                timer.Start();
            }
            pokrenuto = !pokrenuto;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e) {
            vrijeme = 0;
            timer.Stop();
            lblVrijeme.Content = "0,0";
            pokrenuto = false;
        }

        private void btnKrug_Click(object sender, RoutedEventArgs e) {
            if(pokrenuto) {
                lbVremena.Items.Add(decimal.Round((decimal)vrijeme, 1));
            }
        }
    }
}
