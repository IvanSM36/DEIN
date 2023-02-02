using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Practica_IvanSM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void agregarCliente(Object sender, RoutedEventArgs e)
        {
            AgregarCliente ac = new AgregarCliente();

            ac.Show();
        }

       /* private void agregar(Object sender, RoutedEventArgs e)
        {
            // paso a variables los datos de los txtBox
            dni = txtBoxDni.Text;
            nombre = txtBoxNombre.Text;
            edad = int.Parse(txtBoxEdad.Text);

            // Creo un objeto con los datos de los campos 
            Cliente c = new Cliente(dni, nombre, edad);

            // Agrego objeto a la lista de objetos
            clientes.Add(c);
        }*/
    }
}
