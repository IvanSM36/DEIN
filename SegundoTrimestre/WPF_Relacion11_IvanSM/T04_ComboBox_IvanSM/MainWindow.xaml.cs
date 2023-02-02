using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace T04_ComboBox_IvanSM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creo una lista donde luego iremos añadiendo los items
        List<ContactoAgenda> items = new List<ContactoAgenda>();

        public MainWindow()
        {
            InitializeComponent();

        }

        /* *
         * Metodo que abre una nueva ventana y agrega una nueva tarea
         */
        private void agregarContacto(object sender, RoutedEventArgs e)
        {
            Agenda lt = new Agenda();  // Instancio la venatana
            items.Add(new ContactoAgenda(){ Dni = txtBoxDni.Text, Nombre = txtBoxNombre.Text, Anio = comboAnio.Text, Sexo = comboSexo.Text }); // recogo los datos de los txtBox
            lt.lbTareas.ItemsSource = items; // Agrego la tarea
            lt.ShowDialog();// llamo a la ventana

        }
    }
}
