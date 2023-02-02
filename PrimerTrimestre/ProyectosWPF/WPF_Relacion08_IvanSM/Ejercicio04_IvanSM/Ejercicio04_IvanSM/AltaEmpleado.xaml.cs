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
    /// Lógica de interacción para AltaEmpleado.xaml
    /// </summary>
    public partial class AltaEmpleado : Window
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void alta(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Nombre
        {
            get { return txtBlockNombre.Text; }
        }
        public string Salario
        {
            get { return txtBlockSalario.Text; }
        }
    }
}
