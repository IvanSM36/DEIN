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
using System.Windows.Shapes;

namespace UD05_Tarea01_Documentacion_Distribucion_IvanSM
{
    /// <summary>
    /// Lógica de interacción para MostrarDatos.xaml
    /// </summary>
    public partial class MostrarDatos : Window
    {
        public MostrarDatos()
        {
            InitializeComponent();
            // Llamamos al metodo para mostrar la tabla
            FillDataGrid();
        }

        /*
         * Metodo que consulta la tabla Stock y la muestra en un Datagrid
         */
        private void FillDataGrid()
        {
            // Obtiene la cadena de conexión de la BBDD.        
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            // Inicializa una variable para la consulta vacía
            string CmdString = string.Empty;

            // Crea una conexión a la BBDD utilizando la cadena de conexión
            using (SqlConnection con = new SqlConnection(ConString))
            {
                // Creamos la consulta SELECT
                CmdString = "SELECT * FROM Stock";

                //Instanciamos un SqlCommand para conectar la consulta con la BBDD
                SqlCommand cmd = new SqlCommand(CmdString, con);

                // Ejecuta la consulta y llenar un DataTable con los resultados
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Crea un nuevo DataTable 
                DataTable dt = new DataTable("TestDB");

                // Llena el DataTable con los resultados de la consulta
                sda.Fill(dt);

                // Asociamos el DataTable al DataGrid llamado "gdStock"
                gdStock.ItemsSource = dt.DefaultView;

            }

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
         */
        private void btnModificarDatos(object sender, RoutedEventArgs e)
        {
            ModificarDatos md = new ModificarDatos();
            md.Show();
        }

        /*
         * Metodo que abre la ventana Borrar datos
         */
        private void btnBorrarDatos(object sender, RoutedEventArgs e)
        {
            BorrarDatos bd = new BorrarDatos();
            bd.Show();
        }

        /*
         * Metodo que cierra la ventana
         */
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
