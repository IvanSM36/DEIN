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

        // Creamos una lista de persona
        List<Cliente> lc = new List<Cliente>();

        public AgregarCliente()
        {
            InitializeComponent();
        }

        /*
         * Metodo que cierra la ventana
         * 
         */
        private void agregarCliente(Object sender, RoutedEventArgs e)
        {        
           
            //Instanciamos la ventana MostrarClientes para pasar los datos al listView
            MostrarClientes mC = new MostrarClientes();

            //Recogemos los datos en variables
            String dni = txtBoxDni.Text;
            String nombre = txtBoxNombre.Text;
            int edad = int.Parse(txtBoxEdad.Text);

            // Compruebo si no existe el DNI
            if (!existeDNI(dni, lc))
            {
                //Agrego un objeto con los datos recogidos de la ventana agregar cliente
                lc.Add(new Cliente() { Dni = dni, Nombre = nombre, Edad = edad });

                mC.listViewCliente.ItemsSource = lc;
                MessageBox.Show("Se ha agregado el cliente correctamente");

            }
            else
            {
                MessageBox.Show("Ya existe un cliente con ese DNI");
            }

        }

        private bool existeDNI(string dniABuscar, List<Cliente> lista)
        {
            foreach (var item in lista)
            {
                var c = item as Cliente;
                if (c.Dni == dniABuscar)
                {
                    return true;
                }
            }
            return false;
        }


        /*
         * Metodo que agrega un cliente al lIstView que esta en MostrarClientes
         * 
         */
        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Metodo que recoge el dato del campo dni      
        public string Dni
        {
            get { return txtBoxDni.Text; }
        }

        // Metodo que recoge el dato del campo Nombre      
        public string Nombre
        {
            get { return txtBoxNombre.Text; }
        }

        // Metodo que recoge el dato del campo Edad      
        public string Edad
        {
            get { return txtBoxEdad.Text; }
        }
    }
}
