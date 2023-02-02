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

namespace Ejercicio01_IvanSM
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

        private int intentos = 3;

        // Metodo que comprueba la respuesta de la pregunta
        private void comprobar (object sender, RoutedEventArgs e)
        {
            //Comprueba si el radioButton amarillo esta checkeado
            if (rbPlatano.IsChecked == true)
            {
                MessageBox.Show("Correcto.");
            }
            else
            {
                intentos--;// restamos 1 intento si nos equivocamos
                MessageBox.Show("Incorrecto," + " Te quedan " + intentos + " intentos");

            }

            //Comprobamos si no nos quedan intentos bloqueamoslos radiobuttons
            if (intentos == 0)
            {
                // Bloqueamos los radioButton
                rbFresa.IsEnabled = false;
                rbPlatano.IsEnabled = false;
                rbArandano.IsEnabled = false;
                rbPera.IsEnabled = false;
                MessageBox.Show("No tequedan intentos");
            }

        }

    }
}
