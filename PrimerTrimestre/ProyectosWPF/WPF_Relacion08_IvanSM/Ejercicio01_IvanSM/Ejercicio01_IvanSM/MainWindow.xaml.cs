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

        /*
         * Metodo que calcula la letra del dni
         * @param int
         * @return char
         */
        public static char letraDNI(int dni)
        {
            int posicion = 0;
            char letra = ' ';
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            posicion = dni % 23;

            for (int i = 0; i < letras.Length; i++)
            {
                letra = letras[posicion];
            }
            return letra;
        }

        /*
         * Metodo que muestra la letra del dni
         * @param object, KeyEventArgs
         * @return null
         */
        private void mostrarLetraDNI(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int dni = Convert.ToInt32(txtBoxDNI.Text);
                txtBoxDNICompleto.Text = "La letra del DNI es la " + letraDNI(dni);

            }
        }

    }
}
