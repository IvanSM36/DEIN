using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practica_IvanSM
{
    class Cliente
    {
        // Atributos
        private String dni;
        private String nombre;
        private int edad;

        // Constructores

        public Cliente()
        {

        }

        public Cliente(string dni, string nombre, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
        }

        // Guetter and Setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
