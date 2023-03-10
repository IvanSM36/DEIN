using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <value>Propiedad Clientes correspondiente a la lista de los clientes
        /// guardados como una base de datos</value>
        public static List<Cliente> Clientes = new List<Cliente>();
        /// <summary>
        /// Metodo MainWindow que se ejecutara al arrancar la aplicacion
        /// Y que añadira 2 clientes al List de clientes,
        /// e iniciara la ventana de la aplicacion
        /// </summary>
        public MainWindow()
        {
            MainWindow.Clientes.Add(new Cliente()
            {
                Nombre = "Pepe",
                Dni = "123",
                Saldo = 0
            });
            MainWindow.Clientes.Add(new Cliente()
            {
                Nombre = "Jose",
                Dni = "1234",
                Saldo = 2000
            });
            InitializeComponent();
        }

        /// <summary>
        /// Metodo privado que abrira la una ventana para
        /// crear un nuevo cliente en ella
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void nuevoCliente(object sender, RoutedEventArgs e)
        {
            NuevoCliente nv = new NuevoCliente();
            nv.Show();
        }

        /// <summary>
        /// Metodo que escribira en textBox un listado de los clientes que
        /// existen en la lista de cliente
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void verInforme(object sender, RoutedEventArgs e)
        {
            txtInformeCompleto.Text = "";
            if (Clientes.Count == 0)
            {
                txtInformeCompleto.Text = "No existe empleado";
            }
            foreach (var cliente in Clientes)
            {
                if (cliente != null)
                {
                    txtInformeCompleto.Text += "Nombre del Cliente: " + cliente.Nombre + "\n" +
                        " DNI: " + cliente.Dni + "\n" +
                        " Saldo en cuenta: " + cliente.Saldo + "\n\n\n\n" +
                        "************************************\n";
                }
                else { txtInformeCompleto.Text = "No existe empleado"; }
            }
        }

        /// <summary>
        /// Metodo que abrira una nueva ventana para ingresar
        /// dinero a la cuetna de un cliente
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void ingresar(object sender, RoutedEventArgs e)
        {
            Ingresar ingre = new Ingresar();
            ingre.Show();
        }

        /// <summary>
        /// Metodo que abrira una nueva ventana para sacar
        /// dinero de la cuetna de un cliente
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void sacar(object sender, RoutedEventArgs e)
        {
            Sacar sacar = new Sacar();
            sacar.Show();
        }

        /// <summary>
        /// Metodo que abrira una nueva ventana para guardar
        /// Los datos de los clientes que hay en la lsita
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void guardar(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtInformeCompleto.Text);
        }

        /// <summary>
        /// Metodo que abrira una nueva ventana para simular
        /// un prestamo del banco
        /// </summary>
        /// <param name="sender">Es un objeto interno necesario</param>
        /// <param name="e">Es un objeto interno necesario</param>
        /// <returns>No retorna nada</returns>
        private void simular(object sender, RoutedEventArgs e)
        {
            Simulacion sm = new Simulacion();
            sm.Show();
        }
    }
}
