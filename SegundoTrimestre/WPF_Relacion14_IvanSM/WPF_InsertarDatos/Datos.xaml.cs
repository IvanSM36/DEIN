using MySqlX.XDevAPI.Relational;
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
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        public Datos()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AdminDB db = new AdminDB();
            gridDatos.ItemsSource = null;
            db.llenarDatos();
            gridDatos.ItemsSource = db.dsAnimales.Tables["animales"].DefaultView;
            
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
