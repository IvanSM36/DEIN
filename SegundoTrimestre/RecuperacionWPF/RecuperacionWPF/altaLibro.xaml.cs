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
using System.Windows.Shapes;

namespace RecuperacionWPF
{
    /// <summary>
    /// Lógica de interacción para altaLibro.xaml
    /// </summary>
    public partial class altaLibro : Window
    {
        public altaLibro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string darTitulo
        {
            get { return titulo.Text; }
        }
        public string darEditorial
        {
            get { return editorial.Text; }
        }
        public int darPaginas
        {
            get { return int.Parse(paginas.Text); }
        }
        public double darPrecio
        {
            get { return double.Parse(precio.Text); }
        }
        public int darISBN
        {
            get { return int.Parse(ISBN.Text); }
        }
       public int darStock
        {
            get { return int.Parse(stock.Text); }
        }
    }
}
