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

namespace T01_TabControl
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
         *  Metodo que calcula la multiplicacion de los dos valores introducidos en la pestaña 0;
         *  Si los campos de la pestaña 0 tiene uno vacio dará error y ´redireccionará a la pestaña 0
         */
        private void calcular(object sender, MouseButtonEventArgs e)
        {

            int num ;
            int num2 ;

            // Comprueba si los campos estan vacio, si lo estan muestra un MessageBox.show y redirecciona a la pestaña 0
            if (!int.TryParse(txtBoxNum01.Text, out num) || !int.TryParse(txtBoxNum02.Text, out num2))
            {
               MessageBox.Show("Campo vacio, por favor introduzca un valor numerico.", "Campo vacio", MessageBoxButton.OK, MessageBoxImage.Error);
                Pestanias.SelectedIndex = 0;// Redirige a la primera pestaña
            }
            else
            {
                //Si no realiza el calculo
                int resultado = num * num2;

                txtBoxResultado.Text = resultado.ToString();
            }

            
        }


    }
}
