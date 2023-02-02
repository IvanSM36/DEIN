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

namespace WPF_Practica_IvanSM
{
    /// <summary>
    /// Lógica de interacción para AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : Window
    {
        List<Cliente> clientes= new List<Cliente>();
        String dni;
        String nombre;
        int edad;

        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void recogeDatos(Object sender, RoutedEventArgs e)
        {
            
        }

        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
