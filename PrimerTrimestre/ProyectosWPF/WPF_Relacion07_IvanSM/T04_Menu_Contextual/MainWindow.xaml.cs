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

namespace T04_Menu_Contextual
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

        /* *
         * Metodo que abre una ventana message box y muestra el contenido del texto seleccinado
         */
        private void eventoMostrar(object sende , RoutedEventArgs e)
        {
            String textoSeleccionado = txtBox.SelectedText;
            MessageBox.Show(textoSeleccionado, "Texto seleccionado" , MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
