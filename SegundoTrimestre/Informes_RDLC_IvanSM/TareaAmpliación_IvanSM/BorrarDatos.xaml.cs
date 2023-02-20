using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace TareaAmpliación_IvanSM
{
    /// <summary>
    /// Lógica de interacción para BorrarDatos.xaml
    /// </summary>
    public partial class BorrarDatos : Window
    {
        public BorrarDatos()
        {
            InitializeComponent();
        }

        /* * 
         * Metodo que borra un elemento de la tabla Stock mediante el ID introducido 
         * 
         */
        private void btnBorrarDatos(object sender, RoutedEventArgs e)
        {
            // Obtiene la cadena de conexión de la BBDD.        
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            // Inicializa una variable para la consulta vacía
            string CmdString = string.Empty;

            // Crea una conexión a la BBDD utilizando la cadena de conexión
            using (SqlConnection con = new SqlConnection(ConString))
            {
                // Creamos la consulta DELETE
                CmdString = "DELETE FROM Stock WHERE ID = " + int.Parse(txtID.Text) + ";";

                //Instanciamos un SqlCommand para conectar la consulta con la BBDD
                SqlCommand cmd = new SqlCommand(CmdString, con);

                // Abrimos conexion de la BBDD
                con.Open();

                // Ejecuta la consulta DELETE
                cmd.ExecuteNonQuery();

                // Mostramos una ventana indicando que se ha introducido los datos
                MessageBox.Show("Se ha borrado los datos correctamente.", "Datos borrados", MessageBoxButton.OK, MessageBoxImage.Information);

                //Limpiamos el campo
                txtID.Clear();

                // Cerramos conexion
                con.Close();
            }
        }

        /*
         * Metodo que cierra la ventana
         * 
         */
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
