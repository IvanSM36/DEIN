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
       
        public MostrarClientes()
        {
            InitializeComponent();

            // Filtra el listView con el contenido del textBox 
           // CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listViewCliente.ItemsSource);
          //  view.Filter = filtroDni;
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
