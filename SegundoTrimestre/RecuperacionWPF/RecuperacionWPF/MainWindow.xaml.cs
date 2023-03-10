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

namespace RecuperacionWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int posArray = 0;

        public static Libro[] arrayLibro = new Libro[20];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            altaLibro altaLibro = new altaLibro();

            if (altaLibro.ShowDialog() == true)
            {
                string titulo = altaLibro.darTitulo;
                string editorial = altaLibro.darEditorial;
                int pagina = altaLibro.darPaginas;
                double precio = altaLibro.darPrecio;
                int ISBN = altaLibro.darISBN;
                int stock = altaLibro.darStock;
                arrayLibro[posArray] = new Libro(titulo, editorial, pagina, precio, ISBN, stock);
                posArray++;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            buscarLibro buscarlibro = new buscarLibro();
            int ISBN = int.Parse(buscarlibro.darISBN);
            string titulo = buscarlibro.darTitulo;
            bool existe = false;
            if (buscarlibro.ShowDialog() == true)
            {
                for(int i=0; i < posArray; i++)
                {
                    if( arrayLibro[i].getISBN== ISBN | arrayLibro[i].getTitulo.Equals(titulo))
                    {
                        datos.Clear();
                        datos.Text += arrayLibro[i].getTitulo+ "\n";
                        datos.Text += arrayLibro[i].getEditorial + "\n";
                        datos.Text += arrayLibro[i].getPagina + "\n";
                        datos.Text += arrayLibro[i].getISBN + "\n";
                        datos.Text += arrayLibro[i].getPrecio + "\n";
                        datos.Text += arrayLibro[i].getStock + "\n";
                        existe = true;
                    }
                    if (!existe)
                    {
                        MessageBox.Show("el libro no existe");
                    }
                }
            } 
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < posArray; i++)
            {
                datos.Text += arrayLibro[i].getTitulo + "\n";
                datos.Text += arrayLibro[i].getEditorial + "\n";
                datos.Text += arrayLibro[i].getPagina + "\n";
                datos.Text += arrayLibro[i].getISBN + "\n";
                datos.Text += arrayLibro[i].getPrecio + "\n";
                datos.Text += arrayLibro[i].getStock + "\n" + "\n";
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, datos.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
