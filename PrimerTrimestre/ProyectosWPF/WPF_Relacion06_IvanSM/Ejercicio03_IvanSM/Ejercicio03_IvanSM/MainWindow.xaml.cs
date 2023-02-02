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

namespace Ejercicio03_IvanSM
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

        /* *
         *  Metodo Login
         */
        private void login (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El usuario " + txtNombre.Text + " con email " + txtEmail.Text + " envía el mensaje " + txtMensaje.Text, "Mensaje Enviado", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
