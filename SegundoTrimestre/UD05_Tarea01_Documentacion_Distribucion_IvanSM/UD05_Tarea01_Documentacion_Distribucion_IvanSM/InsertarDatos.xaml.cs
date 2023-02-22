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

namespace UD05_Tarea01_Documentacion_Distribucion_IvanSM
{
    /// <summary>
    /// Lógica de interacción para InsertarDatos.xaml
    /// </summary>
    public partial class InsertarDatos : Window
    {

        /// <summary>Initializes a new instance of the <see cref="T:UD05_Tarea01_Documentacion_Distribucion_IvanSM.InsertarDatos" /> class.</summary>
        public InsertarDatos()
        {
            InitializeComponent();
        }

        /// <summary>Metodo que realiza un INSERT en la BBDD.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void btnInsertarDatos(object sender, RoutedEventArgs e)
        {
            // Obtiene la cadena de conexión de la BBDD.        
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            // Inicializa una variable para la consulta vacía
            string CmdString = string.Empty;

            // Crea una conexión a la BBDD utilizando la cadena de conexión
            using (SqlConnection con = new SqlConnection(ConString))
            {
                // Creamos la consulta INSERT
                CmdString = "INSERT INTO Stock(descripcion, unidades, precioventa) VALUES ('" + txtDescripcion.Text + "'," + int.Parse(txtUnidades.Text) + "," + float.Parse(txtPrecioVenta.Text) + ");";

                //Instanciamos un SqlCommand para conectar la consulta con la BBDD
                SqlCommand cmd = new SqlCommand(CmdString, con);
                // Abrimos la conexion
                con.Open();

                // Ejecutamos la consulta
                cmd.ExecuteNonQuery();

                // Mostramos una ventana de informacion
                MessageBox.Show("Se ha agregado los datos correctamente", "Datos agregados", MessageBoxButton.OK, MessageBoxImage.Information);

                // Limpiamos los campos
                txtDescripcion.Clear();
                txtUnidades.Clear();
                txtPrecioVenta.Clear();

                // Cerramos la conexion
                con.Close();

            }

        }

        /// <summary>Metodo que cierra una ventana.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
