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

/*
 * Crea un botón en xaml y asígnale un evento que se lance cuando se haga clic en él. El evento
 * deberá mostrar un mensaje alert por pantalla
 * */

namespace Ejercicio04_IvanSM
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

        private void msgAlerta(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alerta por Subnormal");
        }
    }
}
