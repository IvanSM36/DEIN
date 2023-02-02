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

namespace T01_VentanaDialogoPersonalizado
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
         *  Creo un metodo donde llamamos a la otra ventana y recogemos la respuesta del textTbox email.
         */
        private void aniadirEmail(object sender, RoutedEventArgs e)
        {
            IntroducirEmail email = new IntroducirEmail("Introduzca tu Email: ", " "); // Si no introducimos parametros, coge la pregunta por defecto de la ventana IntroducirEmail.xaml

            if (email.ShowDialog() == true)
            {
                txtEmail.Text = email.Respuesta;
            }
        }
    }
}
