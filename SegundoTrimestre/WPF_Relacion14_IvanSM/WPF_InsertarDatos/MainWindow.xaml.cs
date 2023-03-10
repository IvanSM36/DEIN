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

namespace WPF_InsertarDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdminDB db = new AdminDB();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (db.Conectar())
            {
                txtBlockEstadoBD.Text = "Online";
                txtBlockEstadoBD.Foreground = Brushes.Green;
            }
            else
            {
                txtBlockEstadoBD.Text = "Offline";
                txtBlockEstadoBD.Foreground = Brushes.Red;

            }
            db.Desconectar();
        }


        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            Datos frmDatos = new Datos();
            frmDatos.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            frmDatos.Show();
        }

        private void btnInsertarDatos(object sender, RoutedEventArgs e)
        {
            InsertarDatos insertarDatos= new InsertarDatos();
            insertarDatos.Show();
        }

    }
}
