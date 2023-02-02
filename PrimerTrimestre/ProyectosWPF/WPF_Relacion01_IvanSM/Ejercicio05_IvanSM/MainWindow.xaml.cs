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
 * Modifica la aplicación Ejercicio04 incluyendo un icono para la ventana, y configúrala de forma
 * que el usuario no pueda redimensionarla. Prueba también a que la aplicación
 * automáticamente arranque maximizada
 */

namespace Ejercicio05_IvanSM
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
        private void msgAlerta(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alerta por Subnormal");
        }
    }
}
