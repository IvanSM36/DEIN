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
 * Crea, haciendo uso del elemento “Label” una ventana como la siguiente (fíjate que la N y la
 * M son teclas de acceso rápido pulsando ALT):
 * Al pulsar, por ejemplo, Alt+N, el foco se debe situar en el campo correspondiente. Los
 * cuadros de texto son elementos “TextBox”, que veremos en el siguiente apartado.
 */

namespace Ejercicio04_IvanSM
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
}
