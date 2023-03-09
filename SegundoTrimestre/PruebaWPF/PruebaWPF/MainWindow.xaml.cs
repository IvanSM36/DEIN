using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows;


namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static List<Animal> Animales = new List<Animal>();


        public MainWindow()
        {
            MainWindow.Animales.Add(new Animal()
            {
                Id = 1,
                Raza = "Gallina",
                Sexo = "H",
                StockA = 10,
                Precio = 10
            });
            InitializeComponent();
        }

        private void btnVerInforme(object sender, RoutedEventArgs e)
        {
            boxInforme.Text = "";
            if (Animales.Count == 0)
            {
                boxInforme.Text = "Informe" + "\n-------" + "\nNo hay animales";
            }
            foreach (var animal in Animales)
            {
                if (animal != null)
                {
                    boxInforme.Text += "Informe" +"\n-------" + "\nAnimal: " + animal.Id + "\nRaza: " + animal.Raza + "\nSexo: " + animal.Sexo  + "\nStock: " + animal.StockA + "\nPrecio: " + animal.Precio + "\n----------------\n";
                }
                else { boxInforme.Text = "Informe" + "\n-------" + "\nNo existe el animal"; }
            }
        }

        private void btnguardarInforme(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, boxInforme.Text);
        }

        private void btnAgregarAnimal(object sender, RoutedEventArgs e)
        {
            AgregarAnimales aa = new AgregarAnimales();
            aa.Show();
        }
    }
}
