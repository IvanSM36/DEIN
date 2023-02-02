using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Queue tareas = new Queue();
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Metodo que hace que un boton agregue una tarea
         * @param objet, RoutedEventArgs
         * @return null
         */
        private void agregarTarea(object sender, RoutedEventArgs e)
        {
            tareas.Enqueue(txtBoxResultado.Text);
            txtBoxResultado.Clear();// Limpia el contenido del txtBox
            txtBoxResultado.Text = "La tarea agregada."; // Muestra el mensaje en el textBoxResultado

        }

        /*
         * Metodo que hace que un boton muestre la siguiente Tarea
         * @param objet, RoutedEventArgs
         * @return null
         */
        private void mostrarSiguiente(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            txtBoxResultado.Text = "La siguiente tarea es: " + (string)tareas.Peek();
        }

        /*
         * Metodo que hace que un boton realiza la Tarea y la borra
         * @param objet, RoutedEventArgs
         * @return null
         */
        private void realizarSiguiente(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            txtBoxResultado.Text = "Se ha completado la tarea: " + (string)tareas.Dequeue();

        }

        /*
         * Metodo que hace que un boton muestre el numero de Tareas
         * @param objet, RoutedEventArgs
         * @return null
         */
        private void numeroTareas(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            txtBoxResultado.Text = "Número total de tareas: " + tareas.Count;
        }

        /*
         * Metodo que hace que un boton muestre las tareas pendientes 
         * @param objet, RoutedEventArgs
         * @return null
         */
        private void tareasPendientes(object sender, RoutedEventArgs e)
        {
            txtBoxResultado.Clear();
            txtBoxResultado.Text = "Tareas pendientes: \n";
            foreach (Object tarea in tareas)
            {
                txtBoxResultado.Text = txtBoxResultado.Text + "\n" + tarea;
            }

        }
    }

}
