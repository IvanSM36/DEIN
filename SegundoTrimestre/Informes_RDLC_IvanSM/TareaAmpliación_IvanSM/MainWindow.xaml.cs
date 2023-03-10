using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
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

namespace TareaAmpliación_IvanSM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // Por defecto mostraremos la imagen boton rojo y offline
            txtBlockEstadoBD.Text = "Offline";
            imgEstado.Source = new BitmapImage(new Uri("/image/off.png", UriKind.Relative));
        }

        /*
         * Metodo que comprueba la conexion.
         * 
         */
        private void btnPruebaConectar(object sender, RoutedEventArgs e)
        {
            // Obtiene la cadena de conexión de la BBDD.        
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            // Crea una conexión a la BBDD utilizando la cadena de conexión
            using (SqlConnection con = new SqlConnection(ConString))
            {
                // Si esta conctado
                try
                {
                    con.Open();
                    imgEstado.Source = new BitmapImage(new Uri("/image/on.png", UriKind.Relative));
                    txtBlockEstadoBD.Text = "Online";
                    txtBlockEstadoBD.Foreground = Brushes.Green;
                }
                catch (Exception ex)
                {
                    //Si da error  la conexion
                    imgEstado.Source = new BitmapImage(new Uri("/image/off.png", UriKind.Relative));
                    txtBlockEstadoBD.Text = "Offline";
                    txtBlockEstadoBD.Foreground = Brushes.Red;

                    MessageBox.Show($"Error de conexión: {ex.Message}", "Error de conexion", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        /*
         * Metodo que abre la ventana MostrarDatos
         * 
         */
        private void btnMostrarDatos(object sender, RoutedEventArgs e)
        {
            MostrarDatos md = new MostrarDatos();
            md.Show();
        }

        /*
         * Metodo que abre la ventana de GenerarInforme
         * 
         */
        private void btnGenerarInforme(object sender, RoutedEventArgs e)
        {
            GenerarInforme gi = new GenerarInforme();
            gi.Show();
        }

        /*
         * Metodo que abre la ventana InsertarDatos
         */
        private void btnInsertarDatos(object sender, RoutedEventArgs e)
        {
            InsertarDatos id = new InsertarDatos();
            id.Show();
        }

        /*
         * Metodo que abre la ventana ModificarDatos
         *
         */
        private void btnModificarDatos(object sender, RoutedEventArgs e)
        {
            ModificarDatos md = new ModificarDatos();
            md.Show();
        }

        /* *
         * Metodo que abre la ventana BorrarDatos
         */
        private void btnBorrarDatos(object sender, RoutedEventArgs e)
        {
            BorrarDatos bd = new BorrarDatos();
            bd.Show();
        }

        /*
         *  Metodo que cierra la ventana
         */
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
