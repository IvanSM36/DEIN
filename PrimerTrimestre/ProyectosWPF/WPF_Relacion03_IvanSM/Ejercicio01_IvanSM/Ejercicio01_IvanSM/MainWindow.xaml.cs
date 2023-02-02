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
 * Crea una ventana (grid) dentro de la cual situarás un TextBox que te permita escribir varios
 * párrafos, admitiendo saltos de línea. A medida que se escribe en el TextBox,
 * automáticamente se usan las líneas necesarias (el texto no se corta, salta a la siguiente línea).
 * Además, configura el TextBox de forma que se active automáticamente el corrector
 * ortográfico en castellano. Escribe texto y comprueba que el TextBox funciona tal y como se
 * ha solicitado.
 */

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
    }

    public sealed class SpellCheck
    {

    }
}
