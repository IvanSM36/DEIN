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

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para BuscarAnimal.xaml
    /// </summary>
    public partial class BuscarAnimal : Window
    {
        public BuscarAnimal()
        {
            InitializeComponent();
        }

        private void busAnimal(Object sender, RoutedEventArgs e)
        {
            int id = int.Parse(boxID.Text);
            Animal a = MainWindow.Animales.Find(x => x.Id == id);

            if (a != null)
            {
                MessageBox.Show("El animal ya existe\n" + a.datosAnimal(), "Información animales", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MessageBox.Show("El animal no existe", "Información animal", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();

            }
        }

          private void btnCancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
