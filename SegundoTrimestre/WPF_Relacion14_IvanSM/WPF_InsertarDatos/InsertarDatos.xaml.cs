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
using System.Windows.Shapes;

namespace WPF_InsertarDatos
{
    /// <summary>
    /// Lógica de interacción para InsertarDatos.xaml
    /// </summary>
    public partial class InsertarDatos : Window
    {
        AdminDB db = new AdminDB();

        public InsertarDatos()
        {
            InitializeComponent();
        }

        /*
         * Metodo para conectar a la base de datos 
         */
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Conectar();

        }

        private void btnGuarda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.insertaDatos(txtNombre.Text, txtEspecie.Text, txtRaza.Text, char.Parse(txtSexo.Text));
                MessageBox.Show("Se ha añadido correctamente");
                db.Desconectar();            
            }
            catch
            {
                MessageBox.Show("Error al guardar en la base de datos");
            }
        }

        /*
         * Metodo que cierra la ventana
         *
         */
        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
