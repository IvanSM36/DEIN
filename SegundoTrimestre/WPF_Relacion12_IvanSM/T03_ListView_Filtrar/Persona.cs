using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_ListView_IvanSM
{
    internal class Persona
    {
        // Atributos
        private String nombre;
        private String apellidos;
        private String dni;
        private String email;
        private int edad;

        // Constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellidos, string dni, string email, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.edad = edad;
        }

        // Guetters and Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
