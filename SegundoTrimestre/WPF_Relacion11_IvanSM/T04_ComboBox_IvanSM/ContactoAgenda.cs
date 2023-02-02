using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_ComboBox_IvanSM
{
    class ContactoAgenda
    {
        //Atributos
        private String dni;
        private String nombre;
        private String anio;
        private String sexo;


        // Constructores
        public ContactoAgenda()
        {
        }

        public ContactoAgenda(string dni, string nombre, string anio, string sexo)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Anio = anio;
            this.Sexo = sexo;
        }

        //Getters and Setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
