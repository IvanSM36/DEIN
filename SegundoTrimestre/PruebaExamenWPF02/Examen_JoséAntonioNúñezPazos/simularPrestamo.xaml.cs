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
    /// Lógica de interacción para simularPrestamo.xaml
    /// </summary>
    public partial class simularPrestamo : Window
    {
        public double interes = 0;
        public simularPrestamo()
        {
            InitializeComponent();
        }

        private void simular(object sender, RoutedEventArgs e)
        {
            double cuota = (int.Parse(tbsaldo.Text) + (int.Parse(tbsaldo.Text)*interes/100)) / (int.Parse(tbplazo.Text));
            tbconsola2.Text = "Has pedido un prestamo de " + tbsaldo.Text + " euros a pagar en " + tbplazo.Text + " meses\nTe sale una cuota al mes de " + cuota + " euros";
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void calculaInteres(object sender, RoutedEventArgs e)
        { 
            var objetoEncontrado = MainWindow.Clientes.FirstOrDefault(cliente => cliente.dni == tbdni.Text);
            if (objetoEncontrado != null)
            {
                if (objetoEncontrado.saldo < 1000)
                {
                    interes = 2.95;
                }
                else
                {
                    if(objetoEncontrado.saldo<=3000 && objetoEncontrado.saldo>= 1000)
                    {
                        interes = 2.55;
                    }
                    else
                    {
                        if (objetoEncontrado.saldo > 3000)
                        {
                            interes = 1.95;
                        }
                    }
                }
                tbconsola.Text = "Interés del cliente con DNI " + objetoEncontrado.dni + " : " + interes+"%";

            }
            else
            {
                MessageBox.Show("El cliente introducido no se encuentra");
            }
        }
    }
}
