﻿using System;
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

namespace Examen_JoséAntonioNúñezPazos
{
    /// <summary>
    /// Lógica de interacción para Ingresar.xaml
    /// </summary>
    public partial class Ingresar : Window
    {
        public Ingresar()
        {
            InitializeComponent();
            
        }

        private void ingresar(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
