using System.Windows;

namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Lógica de interacción para NuevoCliente.xaml
    /// </summary>
    public partial class NuevoCliente : Window
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void darAlta(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = MainWindow.Clientes.Find(x => x.Dni.Contains(txtDni.Text));
                if (cli != null)
                {
                    MessageBox.Show("Cliente ya existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MainWindow.Clientes.Add(new Cliente()
                    {
                        Nombre = txtNombreApellidos.Text.ToString(),
                        Dni = txtDni.Text.ToString(),
                        Saldo = 0
                    });
                    MessageBox.Show("Cliente añadido", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }

            }
            catch
            {
                MessageBox.Show("Cliente ya existe", "Información cliente", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
