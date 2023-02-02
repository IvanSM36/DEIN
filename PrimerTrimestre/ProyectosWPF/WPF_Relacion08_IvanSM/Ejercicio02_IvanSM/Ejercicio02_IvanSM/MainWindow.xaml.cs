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

namespace Ejercicio02_IvanSM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private int[,] array;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Metodo que hace que un boton inicialice el array
         * @param objet, RoutedEventArgs
         * @return null
         */
        public void inicializarArray(Object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            int dimension = Convert.ToInt32(txtBoxDimenMatriz.Text);
            array = new int[dimension, dimension];
           

            // Creamos array con numeros randoms 
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    array[j, i] = random.Next(0, 100); // Lo rellenamos con numeros randoms.
                }
            }
            // Mostramos el mensaje en el textBoxResultado
            txtBoxResultado.Text = "El array se ha inicializado correctamente.";
        
        }

        /*
         * Metodo que hace que un boton muestre el contenido del array
         * @param objet, RoutedEventArgs
         * @return null
         */
        public void mostrarArray(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            int dimension = Convert.ToInt32(txtBoxDimenMatriz.Text);       
            // Recorremos el array y mostramos el contenido con numeros randoms 
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    txtBoxResultado.Text = txtBoxResultado.Text + array[i, j] + "\t"; 
                }
               
                txtBoxResultado.Text = txtBoxResultado.Text + "\n";

            }
        }

        /*
         * Metodo que hace que un boton muestre el contenido del array pero invertido
         * @param objet, RoutedEventArgs
         * @return null
         */
        public void mostrarArrayTraspuesta(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            int dimension = Convert.ToInt32(txtBoxDimenMatriz.Text);
            // Pasamos los valores al otro array para cambiar de posicion los numeros 
            for (int i = 0; i < dimension; i++)
            {
                Console.WriteLine();// salto de linea 
                for (int j = 0; j < dimension; j++)
                {
                    txtBoxResultado.Text = txtBoxResultado.Text + array[j, i] + "\t";
                }
                txtBoxResultado.Text = txtBoxResultado.Text + "\n";
            }
        }
    }
}
