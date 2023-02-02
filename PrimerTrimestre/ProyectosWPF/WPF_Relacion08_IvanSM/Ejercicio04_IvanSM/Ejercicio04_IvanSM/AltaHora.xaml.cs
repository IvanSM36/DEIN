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

namespace Ejercicio04_IvanSM
{
    /// <summary>
    /// Lógica de interacción para AltaHora.xaml
    /// </summary>
    public partial class AltaHora : Window
    {
        public AltaHora()
        {
            InitializeComponent();
        }

        private void agregarHora(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Nombre
        {
            get { return txtBlockUsuario.Text; }
        }
        public string Horas
        {
            get { return txtBlockNumHoras.Text; }
        }
    }
}
