using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using T03_SeleccionarTarea;

namespace T01_ListBox_IvanSM
{
    /// <summary>
    /// Lógica de interacción para ListaTareas.xaml
    /// </summary>
    public partial class ListaTareas : Window
    {
        // Creo una lista donde luego iremos añadiendo los items
        List<Tarea> items = new List<Tarea>();

        public ListaTareas()
        {
            InitializeComponent();

        }

        private void seleccionar (Object sender, RoutedEventArgs e)
        {

            foreach (object o in lbTareas.SelectedItems)
                MessageBox.Show("Tarea seleccionada: " + (o as Tarea).Descripcion , "Tarea", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
