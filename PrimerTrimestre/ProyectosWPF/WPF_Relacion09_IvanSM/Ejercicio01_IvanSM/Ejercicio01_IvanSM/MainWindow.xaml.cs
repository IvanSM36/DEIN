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

namespace Ejercicio01_IvanSM
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


        private void colorAzul(object sender, RoutedEventArgs e)
        {
            fondoBorder.Background = Brushes.DarkBlue;
        }

        private void colorNaranja(object sender, RoutedEventArgs e)
        {
            fondoBorder.Background = Brushes.Orange;
        }

        private void colorVerde(object sender, RoutedEventArgs e)
        {
            fondoBorder.Background = Brushes.DarkOliveGreen;
        }
    }
}
