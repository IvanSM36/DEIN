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
    /// Lógica de interacción para MostrarClientes.xaml
    /// </summary>
    public partial class MostrarClientes : Window
    {
        // Creamos una lista de persona
        List<Cliente> lc = new List<Cliente>();

        public MostrarClientes()
        {
            InitializeComponent();

            //Instanciamos la ventana AgregarCaliente para recoger los datos
            AgregarCliente aC = new AgregarCliente();

            String dni = aC.txtBoxDni.Text;
            String nombre = aC.txtBoxNombre.Text;
            int edad = int.Parse(aC.txtBoxEdad.Text);

            //Agrego un objeto con los datos recogidos de la ventana agregar cliente
            lc.Add(new Cliente() { Dni = dni, Nombre = nombre, Edad = edad });

            lisViewCliente.ItemsSource = lc;

            // Filtra el listView con el contenido del textBox 
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lisViewCliente.ItemsSource);
            view.Filter = filtroDni;
        }

        /* *
        * Metodo que filtra por apellidos
        */
        private bool filtroDni(object item)
        {
            if (String.IsNullOrEmpty(txtFiltro.Text))
                return true;
            else
                return ((item as Cliente).Dni.IndexOf(txtFiltro.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        /*
         * Metodo que cierra la ventana
         *
         */
        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
