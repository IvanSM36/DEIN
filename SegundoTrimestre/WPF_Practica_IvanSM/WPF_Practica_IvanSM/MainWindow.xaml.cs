using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.Generic;

namespace WPF_Practica_IvanSM
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

        /*
        * Metodo que abre la ventana Agregar cliente
        */
        private void agregarCliente(Object sender, RoutedEventArgs e)
        {
            AgregarCliente ac = new AgregarCliente();

            ac.Show();
        }

        /*
         * Metodo que abre la ventana buscar cliente
         */
        private void buscarCliente(Object sender, RoutedEventArgs e)
        {
            BuscarCliente bc = new BuscarCliente();

            bc.Show();
        }

        /*
         * Metodo que abre la ventana buscar cliente
         */
        private void listarClientes(Object sender, RoutedEventArgs e)
        {
            MostrarClientes mc = new MostrarClientes();

            mc.Show();
        }

        /* *
       *  Metodo para salir (Solo muestra un messageBox)
       */
        private void archivoSalir(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Salir archivo.", "Salir");
        }

        /* *
       *  Metodo para compartir en instragram (Solo muestra un messageBox)
       */
        private void compartirInstagram(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Compartir en Instagram.", "Compartir instagram");
        }

        /* *
        *  Metodo para compartir en facebook (Solo muestra un messageBox)
        */
        private void compartirFacebook(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Compartir en Facebook.", "Compartir facebook");
        }

        /* *
        *  Metodo para compartir en twitter (Solo muestra un messageBox)
        */
        private void compartirTwitter(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Compartir en Twitter.", "Compartir twitter");
        }

        /* *
       *  Metodo para compartir en otros (Solo muestra un messageBox)
       */
        private void compartirOtros(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Compartir en Otros.", "Compartir en");
        }
    }
}
