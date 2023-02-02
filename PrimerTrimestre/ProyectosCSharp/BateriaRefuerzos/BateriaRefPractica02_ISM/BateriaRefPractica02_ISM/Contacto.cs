using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica02_ISM
{
    internal class Contacto
    {
        // Atributos
        private String nombre;
        private int telefono;
        
        // Constructores
        public Contacto(string nombre, int telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        // Getters and Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }

    }
}
