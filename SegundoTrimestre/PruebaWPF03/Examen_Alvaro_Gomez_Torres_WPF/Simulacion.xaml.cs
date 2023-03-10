using System.Windows;

namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Lógica de interacción para Simulacion.xaml
    /// </summary>
    public partial class Simulacion : Window
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        /// <summary>Cancelars the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void consultar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {
                    if (cli.Saldo < 1000)
                    {
                        txtConsultarInteres.Text = "Interes del cliente con DNI " + cli.Dni + ": 2,95%";
                    }
                    if (cli.Saldo < 3000 && cli.Saldo >= 1000)
                    {
                        txtConsultarInteres.Text = "Interes del cliente con DNI " + cli.Dni + ": 2,55%";
                    }
                    if (cli.Saldo >= 3000)
                    {
                        txtConsultarInteres.Text = "Interes del cliente con DNI " + cli.Dni + ": 1.95%";
                    }

                }
                else
                {
                    MessageBox.Show("Cliente no existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch
            {
                MessageBox.Show("Cliente no existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void simular(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {
                    
                    double interes = 0;
                    if (cli.Saldo < 1000)
                    {
                        interes = 2.95;
                    }
                    if (cli.Saldo < 3000 && cli.Saldo >= 1000)
                    {
                        interes = 2.55;
                    }
                    if (cli.Saldo >= 3000)
                    {
                        interes = 1.95;
                    }
                    double cuota = 0;
                    cuota = (int.Parse(txtCapitalSolicitado.Text) + (int.Parse(txtCapitalSolicitado.Text) * interes / 100)) / int.Parse(txtPlazo.Text);
                    txtSimulacion.Text = "Haz pedido un prestamo de " + txtCapitalSolicitado.Text + " a pagar en " + txtPlazo.Text + " meses\n Te sale una cuota al mes de " + cuota.ToString() + " euros";
                }
                else
                {
                    MessageBox.Show("Cliente no existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch
            {
                MessageBox.Show("Cliente no existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
