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


        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            Datos frmDatos = new Datos();
            frmDatos.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            frmDatos.Show();
        }

    }

}
