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

/*
 * Crea un botón en xaml y genera un evento en cuyo interior se fuerce una excepción (por
 * ejemplo, escribir en un array en una posición mayor a la máxima). Comprueba que la
 * aplicación se cierra de forma abrupta. Realiza las modificaciones necesarias para que se
 * capture la excepción.
 */

namespace Ejercicio06_IvanSM
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

        private void msgException(object sender, RoutedEventArgs E)
        {
            String[] animales = new string[4];
            try
            {
                animales[0] = "Lobo";
                animales[1] = "Zorro";
                animales[2] = "Caballo";
                animales[3] = "Toro";
                animales[4] = "Perro";
                animales[5] = "Gallina";
                MessageBox.Show(animales[0] + "\n" + animales[1] + "\n" + animales[2] + "\n" + animales[3]);
            }
            catch(Exception ex) {
            MessageBox.Show("Se esta intentando agregar mas contenido de lo permitido en el array: " + ex.Message);
            }

           
      
        }
    }
}
