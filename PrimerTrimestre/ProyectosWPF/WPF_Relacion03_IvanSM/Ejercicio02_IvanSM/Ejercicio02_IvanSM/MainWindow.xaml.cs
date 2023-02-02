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
using System.Windows.Xps;

/*
 * Crea una ventana con un TextBox en el que puedes introducir texto. Crea otro TextBox
 * debajo, pero que no permita escribir nada, sino que indique “Has seleccionado XXX” donde
 * XXX es el texto seleccionado en el TextBox primero
 */

namespace Ejercicio02_IvanSM
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
    }

    private void seleccionarTexto(object sender, RoutedEventArgs e)
    {
        TextBox textBox1 = sender as TextBox;
        if (!String.IsNullOrEmpty(textBox1.Text))
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }
    }

}
