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
    /// Lógica de interacción para BuscarCliente.xaml
    /// </summary>
    public partial class BuscarCliente : Window
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        /* *
         * Metodo que busca los datos de un cliente mediante DNI
         * 
         */
        private void buscarCliente(Object sender, RoutedEventArgs e) 
        {
            MostrarClientes mC = new MostrarClientes();

        }

        /* *
         * Metodo que cierra la ventana
         *
         */
        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
