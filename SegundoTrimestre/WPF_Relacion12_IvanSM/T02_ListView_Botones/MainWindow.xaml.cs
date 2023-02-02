using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using T01_ListView_IvanSM;

namespace T02_ListView_Botones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Creamos una lista de persona
            List<Persona> lp = new List<Persona>();

            lp.Add(new Persona() { Nombre = "Ivan", Apellidos = "Salguero", Dni = "44444444-W", Email = "ivan_sm@hotmail.es", Edad = 26 });

            lp.Add(new Persona() { Nombre = "Manuel", Apellidos = "Cabeza", Dni = "55555555-P", Email = "manuel@gmail.com", Edad = 28 });

            lp.Add(new Persona() { Nombre = "Ainoa", Apellidos = "Pozo", Dni = "44444444-W", Email = "ainoa@hotmail.es", Edad = 26 });

            lp.Add(new Persona() { Nombre = "Andrea", Apellidos = "Serrano", Dni = "77777777-W", Email = "andrea@hotmail.es", Edad = 24 });

            lvTabla.ItemsSource = lp;
           
        }

        private void ordenarApellidos(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvTabla.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Apellidos",
            ListSortDirection.Ascending));
        }

        private void ordenarEdad(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvTabla.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Edad",
            ListSortDirection.Ascending));
        }

    }
}
