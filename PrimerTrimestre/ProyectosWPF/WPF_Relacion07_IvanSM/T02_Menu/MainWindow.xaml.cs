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

namespace T02_Menu
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
         *  Metodo para crear un nuevo documento (Solo muestra un messageBox)
         */
        private void archivoNuevo(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Nuevo archivo.", "Archivo nuevo");
        }

        /* *
         *  Metodo para abrir un nuevo documento (Solo muestra un messageBox)
         */
        private void archivoAbrir(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Abrir archivo.", "Abrir archivo");
        }

        /* *
         *  Metodo para guardar un documento (Solo muestra un messageBox)
         */
        private void archivoGuardar(Object sende, RoutedEventArgs e)
        {
            MessageBox.Show("Guardar archivo.", "Guardar archivo");
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
