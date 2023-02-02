using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Realiza el ejercicio anterior pero dentro del .cs (tienes de eliminar el grid en el xaml y crearlo
 * todo en el .cs.
 */

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

            //Declaramos un Grid
            Grid miGrid = new Grid();
            this.Content= miGrid;

            // Creo boton
            Button btn = new Button();
            btn.FontWeight= FontWeights.Bold;   

            // Creo panel
            WrapPanel pnl = new WrapPanel();

            // Creo TextBlock
            TextBlock txt = new TextBlock();
            txt.Text = "Texto01";
            // Damos color al texto
            txt.Foreground = Brushes.Green;
            
            //Agregamos el texto al panel
            pnl.Children.Add(txt);  

            //Creamos texto02 y lo añadimos
            txt = new TextBlock();
            txt.Text = "Texto02";
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            //Creamos texto03 y lo añadimos
            txt = new TextBlock();
            txt.Text = "Texto02";
            pnl.Children.Add(txt);

            //Añadimos el boton al panel 
            btn.Content = pnl;
            miGrid.Children.Add(btn);
        }
    }
}
