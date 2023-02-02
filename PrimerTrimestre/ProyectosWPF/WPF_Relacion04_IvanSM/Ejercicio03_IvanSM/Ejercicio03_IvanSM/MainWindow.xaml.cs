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

namespace Ejercicio03_IvanSM
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

        private String user = "admin";
        private String pass = "admin";

        //Metodo que inicia sesion 
        private void iniciarSesion(object sender, RoutedEventArgs e)
        {
            // Recogemos los datos introducidos
            String datosUser = txtUser.Text;
            String datosPass = passBoxUser.Password;

            //Comprobamos los datos introducidos para saber si son correctos o no
            if (datosUser.Equals(user) && datosPass.Equals(pass))
            {
                MessageBox.Show("Se ha iniciado sesion correctamente.");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta." );
            }
        }
    }

}
