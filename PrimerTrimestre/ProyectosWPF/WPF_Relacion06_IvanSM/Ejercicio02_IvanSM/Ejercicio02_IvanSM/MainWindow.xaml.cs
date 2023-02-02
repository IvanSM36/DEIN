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
        public MainWindow()
        {
            InitializeComponent();
        }

        /* *
         *  Metodo que comprueba si hay texto seleccionado 
         */
        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        /* *
         *  Metodo que corta el texto seleccionado del textBox
         */
        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs
        e)
        {
            txtEditor.Cut();
        }

        /* * 
         *  Metodo que comprueba si hay algo copiado en el portapapeles
         */
        private void PasteCommand_CanExecute(object sender,
        CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        /* *
         *  Metodo que pega lo que tenga el portapapeles
         */
        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }

    }
}
