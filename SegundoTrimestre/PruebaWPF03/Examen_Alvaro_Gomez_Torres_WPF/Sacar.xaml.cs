using System.Windows;

namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Lógica de interacción para Sacar.xaml
    /// </summary>
    public partial class Sacar : Window
    {
        public Sacar()
        {
            InitializeComponent();
        }

        private void sacar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {
                    if (cli.Saldo <= 0)
                    {
                        MessageBox.Show("La cuenta ya esta a 0", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        if (cli.Saldo <= int.Parse(txtCantidad.Text))
                        {
                            cli.Saldo = 0;
                            MessageBox.Show("Saldo restado", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();
                        }
                        else
                        {
                            cli.Saldo = cli.Saldo - int.Parse(txtCantidad.Text);
                            MessageBox.Show("Saldo restado", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();
                        }
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

        private void consultar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {

                    txtConsultarSaldo.Text = "Saldo del cliente con DNI " + cli.Dni + ": " + cli.Saldo.ToString();
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

        private void cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
