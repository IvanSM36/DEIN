using System.Windows;

namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Lógica de interacción para Ingresar.xaml
    /// </summary>
    public partial class Ingresar : Window
    {
        public Ingresar()
        {
            InitializeComponent();
        }
         
        /// <summary>Metodo para ingresar una cantidad a un cliente.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void ingresar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {
                    cli.Saldo = cli.Saldo + int.Parse(txtCantidad.Text);
                    MessageBox.Show("Saldo añadido", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                    cli.dameNombre();
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
