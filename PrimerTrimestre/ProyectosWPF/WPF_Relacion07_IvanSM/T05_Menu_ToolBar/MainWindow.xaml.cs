using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace T05_Menu_ToolBar
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
        private void eventoMostrar(object sende, RoutedEventArgs e)
        {
            String textoSeleccionado = txtEditor.SelectedText;
            MessageBox.Show(textoSeleccionado, "Texto seleccionado", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /* *
         * Metodo para abrir un fichero .txt
         */
        private void btnAbrirArchivo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt"; // Filtra para que solo se pueda abrir archivos .txt
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Establece el directorio inicial en la carpeta "Escritorio"

            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }

        /* *
         * Metodo que guarda el contenido del textBox en un archivo .txt
         */
        private void btnGuardarArchivo(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";// Hace que solo se pueda guardar con formato .txt
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Establece el directorio inicial en la carpeta "Escritorio"

            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }

    }
}
