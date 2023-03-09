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

namespace Examen_JoséAntonioNúñezPazos
{
    /// <summary>
    /// Lógica de interacción para NuevoCliente.xaml
    /// </summary>
    public partial class NuevoCliente : Window
    {
        public MainWindow w1 = new MainWindow();
        public NuevoCliente()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }
    }

    public class cliente
    {
        //Atributos
        public String nombreyApellidos { get; set; }
        public String dni { get; set; }
        public float saldo { get; set; }

        public cliente(string nombreyApellidos, string dni)
        {
            this.nombreyApellidos = nombreyApellidos;
            this.dni = dni;
            this.saldo = 0;
        }
    }
}
