using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace T03_ListView_Filtrar
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

            // Agregamos contenido a la Lista
            lp.Add(new Persona() { Nombre = "Ivan", Apellidos = "Salguero", Dni = "44444444-W", Email = "ivan_sm@hotmail.es", Edad = 26 });

            lp.Add(new Persona() { Nombre = "Manuel", Apellidos = "Cabeza", Dni = "55555555-P", Email = "manuel@gmail.com", Edad = 28 });

            lp.Add(new Persona() { Nombre = "Ainoa", Apellidos = "Pozo", Dni = "44444444-W", Email = "ainoa@hotmail.es", Edad = 26 });

            lp.Add(new Persona() { Nombre = "Andrea", Apellidos = "Serrano", Dni = "77777777-W", Email = "andrea@hotmail.es", Edad = 24 });

            lvTabla.ItemsSource = lp;

            // Filtra el listView con el contenido del textBox 
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvTabla.ItemsSource);
            view.Filter = filtroApellidos;
        }

        /* *
         * Metodo que filtra por apellidos
         */
        private bool filtroApellidos(object item)
        {
            if (String.IsNullOrEmpty(txtFiltro.Text))
                return true;
            else 
                return ((item as Persona).Apellidos.IndexOf(txtFiltro.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        /* *
         * Metodo que actualiza en tiempo real el ListView segun va escribiendo en el textBox
         */
        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvTabla.ItemsSource).Refresh();
        }

    }
}
