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

namespace WPF_Practica_IvanSM
{
    /// <summary>
    /// Lógica de interacción para AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : Window
    {

        public AgregarCliente()
        {
            InitializeComponent();
        }
        /// Furula o no?


        /*
         * Metodo que cierra la ventana
         * 
         */
        private void cerrarVentana(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Metodo que recoge el dato del campo dni      
        public string Dni
        {
            get { return txtBoxDni.Text; }
        }

        // Metodo que recoge el dato del campo Nombre      
        public string Nombre
        {
            get { return txtBoxNombre.Text; }
        }

        // Metodo que recoge el dato del campo Edad      
        public string Edad
        {
            get { return txtBoxEdad.Text; }
        }
    }
}
