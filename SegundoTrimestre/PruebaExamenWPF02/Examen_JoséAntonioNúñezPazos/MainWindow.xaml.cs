using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace Examen_JoséAntonioNúñezPazos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static List<cliente> Clientes = new List<cliente>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            NuevoCliente v = new NuevoCliente();
            if (v.ShowDialog() == true)
            {
                var objetoEncontrado = Clientes.FirstOrDefault(cliente => cliente.dni == v.tbdni.Text);
                if (objetoEncontrado != null)
                {
                    MessageBox.Show("El cliente introducido ya existe");
                    
                }
                else
                {
                    cliente c1 = new cliente(v.tbnombreapellido.Text, v.tbdni.Text);
                    Clientes.Add(c1);
                    MessageBox.Show("Se ha creado un nuevo cliente", "Alerta de añadido", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
        }

        private void Informe(object sender, RoutedEventArgs e)
        {
            tbconsola.Clear();
            if (Clientes.Count != 0)
            {
                for (int i = 0; i < Clientes.Count; i++)
                {
                    tbconsola.Text += "Nombre del cliente: " + Clientes[i].nombreyApellidos + "\nDNI: " + Clientes[i].dni + "\nSaldo en cuenta: " + Clientes[i].saldo + "\n\n\n************\n";
                }
            }
            else
            {
                MessageBox.Show("No existen clientes");
            }

        }

        private void ingresa(object sender, RoutedEventArgs e)
        {
            Ingresar v = new Ingresar();
            if (v.ShowDialog() == true)
            {
                var objetoEncontrado = MainWindow.Clientes.FirstOrDefault(cliente => cliente.dni == v.tbdni.Text);
                if (objetoEncontrado != null)
                {

                    objetoEncontrado.saldo += float.Parse(v.tbsaldo.Text);
                    MessageBox.Show("Se ha ingresado una cantidad de " + v.tbsaldo.Text + " al cliente con usuario" + v.tbdni.Text, "Alerta de ingreso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("El cliente introducido no se encuentra");
                }
            }
        }

        private void sacar(object sender, RoutedEventArgs e)
        {
            Retirar v = new Retirar();
            if(v.ShowDialog() == true)
            {
                var objetoEncontrado = MainWindow.Clientes.FirstOrDefault(cliente => cliente.dni == v.tbdni.Text);
                if (objetoEncontrado != null)
                {

                    objetoEncontrado.saldo -= float.Parse(v.tbsaldo.Text);
                    MessageBox.Show("Se ha retirado una cantidad de " + v.tbsaldo.Text + " al cliente con usuario" + v.tbdni.Text, "Alerta de ingreso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("El cliente introducido no se encuentra");
                }

            }
        }

        private void guardarInforme(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt";

            if (sfd.ShowDialog() == true)
            {
                File.WriteAllText(sfd.FileName, tbconsola.Text);
            }
        }

        private void simular(object sender, RoutedEventArgs e)
        {
            simularPrestamo v = new simularPrestamo();
            v.Show();

        }
    }
}
