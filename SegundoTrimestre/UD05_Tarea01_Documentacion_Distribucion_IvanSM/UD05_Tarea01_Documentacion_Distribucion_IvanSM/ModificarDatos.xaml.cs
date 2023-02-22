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
    /// Lógica de interacción para ModificarDatos.xaml
    /// </summary>
    public partial class ModificarDatos : Window
    {
        public ModificarDatos()
        {
            InitializeComponent();
        }
    
        /// <summary>Metodo que realiza una consulta UPDATE a la BBDD.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void btnModificarDatos(object sender, RoutedEventArgs e)
        {

            // Obtiene la cadena de conexión dela BBDD.        
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            // Inicializa una variable para la consulta vacía
            string CmdString = string.Empty;

            // Crea una conexión a la BBDD utilizando la cadena de conexión
            using (SqlConnection con = new SqlConnection(ConString))
            {
                // Creamos la consulta UPDATE
                CmdString = "UPDATE Stock SET descripcion= '" + txtDescripcion.Text + "', unidades= " + int.Parse(txtUnidades.Text) + ", precioventa= " + float.Parse(txtPrecioVenta.Text) + " where id=" + int.Parse(txtID.Text) + ";";

                //Instanciamos un SqlCommand para conectar la consulta con la BBDD
                SqlCommand cmd = new SqlCommand(CmdString, con);

                //Abrimos la conexion
                con.Open();
                // Ejecutamos la consulta UPDATE
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha actualizado los datos correctamente", "Datos actualizados", MessageBoxButton.OK, MessageBoxImage.Information);

                // Limpiamos los campos
                txtID.Clear();
                txtDescripcion.Clear();
                txtUnidades.Clear();
                txtPrecioVenta.Clear();

                // Cerramos la conexion
                con.Close();

            }
        }

        /// <summary>Metodo que cierra la ventana.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}
