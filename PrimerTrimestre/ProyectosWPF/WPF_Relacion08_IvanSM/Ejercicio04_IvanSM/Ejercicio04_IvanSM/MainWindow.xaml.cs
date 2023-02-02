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

namespace Ejercicio04_IvanSM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        static int opcion;
        static int posArray = 0;
        static Empleado[] arrayEmpleados = new Empleado[15];

        /* *
         * Metodo que inicializa el array
         */
        static void inicializaArray()
        {
            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                arrayEmpleados[i] = null;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            inicializaArray();
        }

        /* *
         * Metodo que se le asigna a un boton que abre la ventana Alta empleado
         * @param objet, routedEventArgs
         * @return null
         */
        private void altaEmpleado(object sender, RoutedEventArgs e)
        {
            // Instanciamos la ventana AltaEmpleado y Login
            AltaEmpleado ventanaAltaEmpleado = new AltaEmpleado();
            Login ventanaLogin = new Login();

            // Esablecemos un usuario y contraseña
            String user = "admin";
            String pass = "admin";      

            // Mostramos la ventanaLogin
            if(ventanaLogin.ShowDialog() == true)
            {
                // Recogemos los datos introducidos
                String datosUser = Convert.ToString(ventanaLogin.Usuario);
                String datosPass = Convert.ToString(ventanaLogin.Pass);

                // Comparamos si el usuario y contraseña es correcta
                if (datosUser.Equals(user) && datosPass.Equals(pass))
                {
                    // Lanzamos una ventana con el mensaje siguiente
                    MessageBox.Show("Has iniciaro sesion correctamente.");

                    // Lanzamos la ventana de AltaEmpleado
                    if (ventanaAltaEmpleado.ShowDialog() == true)
                    {
                        // Recogemos los datos introducidos
                        String nombre = ventanaAltaEmpleado.Nombre;
                        int salario = Convert.ToInt32(ventanaAltaEmpleado.Salario);

                        // Introducimos los datos en el array
                        arrayEmpleados[posArray] = new Empleado(nombre, salario);
                        posArray++;
                    }
                }
                else
                {
                    // Si la contraseña es incorrecta lanza una ventana con el siguiente mensaje
                    MessageBox.Show("Error, Usuario o contraseña incorrecto");
                }
            }

        }

        /*
         * Metodo que se le asigna a un boton que abre la ventana Login y si es correcto muestra la informacion 
         * @param objet, routedEventArgs
         * @return null
         */
        private void informeCompleto(object sender, RoutedEventArgs e)
        {
            Login ventanaLogin = new Login();

            String user = "admin";
            String pass = "admin";

            if (ventanaLogin.ShowDialog() == true)
            {
                String datosUser = Convert.ToString(ventanaLogin.Usuario);
                String datosPass = Convert.ToString(ventanaLogin.Pass);

                if (datosUser.Equals(user) && datosPass.Equals(pass))
                {
                    MessageBox.Show("Has iniciaro sesion correctamente.");

                    txtBoxResultado.Clear();

                    // Recorre el array empleados y muestra la informacion de los empleados en el textBox resultado
                    for (int i = 0; i < posArray; i++)
                    {
                        txtBoxResultado.Text += "Nombre del empleado: " + arrayEmpleados[i].getNombre + "\n";
                        txtBoxResultado.Text += "Salario: " + arrayEmpleados[i].getSalario + "\n";
                        txtBoxResultado.Text += "Horas extras totales: " + arrayEmpleados[i].getNumHorasExtra + "\n";
                        txtBoxResultado.Text += "Salario total: " + arrayEmpleados[i].CalculaSalarioTotal() + "\n\n\n";
                    }

                }
                else
                {
                    MessageBox.Show("Error, Usuario o contraseña incorrecto");
                }
            }
        }

        /*
         * Metodo que se le asigna a un boton que abre la ventana Login y si es correcto muestra la informacion 
         * @param objet, routedEventArgs
         * @return null
         */
        private void insertarHorasExtras(object sender, RoutedEventArgs e)
        {
            AltaHora ventanaAltaHora = new AltaHora();
            Login ventanaLogin = new Login();

            String user = "admin";
            String pass = "admin";

            if (ventanaLogin.ShowDialog() == true)
            {
                String datosUser = Convert.ToString(ventanaLogin.Usuario);
                String datosPass = Convert.ToString(ventanaLogin.Pass);

                if (datosUser.Equals(user) && datosPass.Equals(pass))
                {
                    MessageBox.Show("Has iniciaro sesion correctamente.");

                    if (ventanaAltaHora.ShowDialog() == true)
                    {

                        //Recogemos los datos introducidos
                        String nombre = ventanaAltaHora.Nombre;
                        int horas = Convert.ToInt32(ventanaAltaHora.Horas);
                        bool usuarioExiste = false;

                        //  recorremos el array empleado
                        for (int i = 0; i < posArray; i++)
                        {
                            //Si el nombre es el mismo que el introducido
                            if (arrayEmpleados[i].getNombre.Equals(nombre))
                            {
                                //Añadimos la hora extra
                                arrayEmpleados[i].HaceHoraExtra(horas);
                                usuarioExiste = true;
                            }
                        }
                        if (!usuarioExiste)
                        {
                            MessageBox.Show("El usuario no existe");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Usuario o contraseña incorrecto");

                    }
                }
            }

        }

        /*
         * Metodo que se le asigna a un boton que abre la ventana Login y si es correcto muestra las horas totales de todos los empleados 
         * @param objet, routedEventArgs
         * @return null
         */
        private void horasExtrasTotales(object sender, RoutedEventArgs e)
        {
            Login ventanaLogin = new Login();

            String user = "admin";
            String pass = "admin";

            if (ventanaLogin.ShowDialog() == true)
            {
                String datosUser = Convert.ToString(ventanaLogin.Usuario);
                String datosPass = Convert.ToString(ventanaLogin.Pass);

                if (datosUser.Equals(user) && datosPass.Equals(pass))
                {
                    MessageBox.Show("Has iniciaro sesion correctamente.");

                    int total = 0;
                    txtBoxResultado.Clear();// Limpia el textBox resultado

                    //Recorre el array de los empleados y suma todas las horas extras
                    for (int i = 0; i < posArray; i++)
                    {
                        total += arrayEmpleados[i].getNumHorasExtra;
                    }

                    //Muesta en el textBox resultado las horas totales de los empleados
                    txtBoxResultado.Text += "Horas extras totales de todos los empleados: " + total + "\n";
                }
                else
                {
                    MessageBox.Show("Error, Usuario o contraseña incorrecto");

                }
            }
        }

    }
}
