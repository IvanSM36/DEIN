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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T02_ProgressBar_IvanSM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creo una lista donde luego iremos añadiendo los items
        List<Tarea> items = new List<Tarea>();

        public MainWindow()
        {
            InitializeComponent();

        }

        /* *
         * Metodo que abre una nueva ventana y agrega una nueva tarea
         */
        private void agregarTarea(object sender, RoutedEventArgs e)
        {
            ListaTareas lt = new ListaTareas();  // Instancio la venatana
            items.Add(new Tarea() { Descripcion = txtBoxDescripcion.Text, Prioridad = int.Parse(txtBoxPrioridad.Text), NivelRealizacion = int.Parse(txtBoxRealizacion.Text) }); // recogo los datos de los txtBox
            lt.lbTareas.ItemsSource = items; // Agrego la tarea
            lt.ShowDialog();// llamo a la ventana

        }
    }
}
