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

namespace Examen_JoséAntonioNúñezPazos
{
    /// <summary>
    /// Lógica de interacción para Retirar.xaml
    /// </summary>
    public partial class Retirar : Window
    {
        public Retirar()
        {
            InitializeComponent();

        }

        private void retirar(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void consulta(object sender, RoutedEventArgs e)
        {
            var objetoEncontrado = MainWindow.Clientes.FirstOrDefault(cliente => cliente.dni == tbdni.Text);
            if (objetoEncontrado != null)
            {
                tbconsola.Text = "Saldo del cliente con DNI " + objetoEncontrado.dni+" : "+objetoEncontrado.saldo;
                
            }
            else
            {
                MessageBox.Show("El cliente introducido no se encuentra");
            }
        }
    }
}
