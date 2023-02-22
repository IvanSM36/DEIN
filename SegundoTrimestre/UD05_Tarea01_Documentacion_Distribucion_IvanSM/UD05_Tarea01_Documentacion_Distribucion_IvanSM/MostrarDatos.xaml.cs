// ***********************************************************************
// Assembly         : UD05_Tarea01_Documentacion_Distribucion_IvanSM
// Author           : IvanSM
// Created          : 02-22-2023
//
// Last Modified By : IvanSM
// Last Modified On : 02-22-2023
// ***********************************************************************
// <copyright file="MostrarDatos.xaml.cs" company="">
//     Copyright ©  2023
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// <summary>
        /// Initializes a new instance of the <see cref="MostrarDatos"/> class.
        /// </summary>
        public MostrarDatos()
        {
            InitializeComponent();
            // Llamamos al metodo para mostrar la tabla
            FillDataGrid();
        }


        /// <summary>
        /// Fills the data grid.
        /// </summary>
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

        /// <summary>
        /// BTNs the insertar datos.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnInsertarDatos(object sender, RoutedEventArgs e)
        {
            InsertarDatos id = new InsertarDatos();
            id.Show();
        }


        /// <summary>
        /// BTNs the modificar datos.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnModificarDatos(object sender, RoutedEventArgs e)
        {
            ModificarDatos md = new ModificarDatos();
            md.Show();
        }

        /// <summary>
        /// BTNs the borrar datos.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnBorrarDatos(object sender, RoutedEventArgs e)
        {
            BorrarDatos bd = new BorrarDatos();
            bd.Show();
        }


        /// <summary>
        /// BTNs the cerrar ventana.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnCerrarVentana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
