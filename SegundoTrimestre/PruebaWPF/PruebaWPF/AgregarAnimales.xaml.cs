using Microsoft.Win32;
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

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para AgregarAnimales.xaml
    /// </summary>
    public partial class AgregarAnimales : Window
    {
        public AgregarAnimales()
        {

            InitializeComponent();
        }

        private void agregarAnimal(Object sender, RoutedEventArgs e )
        {
            int id = int.Parse(boxID.Text);
            Animal a = MainWindow.Animales.Find(x => x.Id == id);

            if (a != null) {
                MessageBox.Show("El animal ya existe", "Información animales", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MainWindow.Animales.Add(new Animal()
                {
                    Id = int.Parse(boxID.Text.ToString()),
                    Raza = boxRaza.Text.ToString(),
                    StockA = int.Parse(boxStock.Text.ToString()),
                    Sexo = boxSexo.Text.ToString(),
                    Precio = float.Parse(boxPrecio.Text)
                });

                MessageBox.Show("El animal se ha añadido", "Información animal", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
             
            }
          

            Close();
            
        }

      

    }
}
