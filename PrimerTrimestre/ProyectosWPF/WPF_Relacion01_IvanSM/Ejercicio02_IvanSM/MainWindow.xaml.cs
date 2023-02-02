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
 * Mediante XAML, crea un botón situado dentro del grid, y configúrale la letra del botón en
 * “Bold”, crea dentro un wrap panel (dentro de Button.Content) con 3 bloques TextBlock, el
 * primero con color verde, el segundo en color azul y el tercero sin formato
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
}
