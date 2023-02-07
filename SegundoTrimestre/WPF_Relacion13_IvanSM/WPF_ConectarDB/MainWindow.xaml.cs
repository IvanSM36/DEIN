using InsertaDatos;
using MySqlConnector;
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

namespace WPF_ConectarDB
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminDB db = new AdminDB();
            db.Conectar();
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string server = "212.227.147.133";
                string database = "ZooTerra";
                string user = "root";
                string pwd = "root";
                string cadenaConexion = "server=" + server + ";database=" + database + ";id=" + user + ";pwd=" + pwd + ";";
              //  MySqlConnection con = new MySqlConnection(cadenaConexion);
             //   con.Open();
                MessageBox.Show("Se ha conectado correctamente");
            }
            catch(Exception E)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }
            
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            Datos frmDatos = new Datos();
            frmDatos.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            frmDatos.Show();
        }

        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string server = "212.227.147.133";
                string database = "ZooTerra";
                string user = "root";
                string pwd = "root";
                string cadenaConexion = "server=" + server + ";database=" + database + ";user=" + user + ";pwd=" + pwd + ";";
               // MySqlConnection myCon = new MySqlConnection(cadenaConexion);
              //  myCon.Open();
                MessageBox.Show("Se ha conectado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD" + error);
            }
        }


       

        //Funciona
        private void btnConectar02(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new();
                builder.Server = "212.227.147.133";
                builder.Database = "ZooTerra";
                builder.UserID = "root";
                builder.Password = "root";
                //string cadenaConexion = "server=" + server + ";database=" + database + ";user=" + user + ";pwd=" + pwd + ";";
                using var connection = new MySqlConnection(builder.ToString());
                connection.Open();
                // MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                //  myCon.Open();
                MessageBox.Show("Se ha conectado correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD" + error);
            }
        }

        private void btnMostrarDatosBD(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new();
                builder.Server = "212.227.147.133";
                builder.Database = "ZooTerra";
                builder.UserID = "root";
                builder.Password = "root";
                var connection = new MySqlConnection(builder.ToString());
                connection.Open();
                
                using var command = new MySqlCommand("SELECT * FROM Animales;", connection);
                Datos frmDatos = new Datos();
                
                frmDatos.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD" + error);
            }
        }


    }

}
