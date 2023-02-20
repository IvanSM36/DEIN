using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD05_Tarea01_Documentacion_Distribucion_IvanSM
{
    internal class Coche
    {
        // Atributos
        private int id;
        private String matricula;
        private String marca;
        private String modelo;
        private String color;

        // Constructores

        /// <summary>
        /// Constructor del objeto coche vacio
        /// </summary>
        public Coche()
        {
        }

        /// <summary>
        /// Constructor del objeto coche con todos los parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="matricula"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="color"></param>
        public Coche(int id, string matricula, string marca, string modelo, string color)
        {
            this.id = id;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
        }

        // Getters and setters

        /// <value>Get y Set del atributo ID </value>    
        public int Id { get => id; set => id = value; }

        /// <value>Get y Set del atributo matricula </value>    
        public string Matricula { get => matricula; set => matricula = value; }

        /// <value>Get y Set del atributo marca </value>    
        public string Marca { get => marca; set => marca = value; }

        /// <value>Get y Set del atributo modelo </value>    
        public string Modelo { get => modelo; set => modelo = value; }

        /// <value>Get y Set del atributo color </value>    
        public string Color { get => color; set => color = value; }

        // Metodos

        /// <summary>
        /// Metodo que muestra un string simulando que acelera
        /// </summary>
        /// <param name=""></param>
        /// <returns>String</returns>
        public String acelerar()
        {
            return "Fiiiiumm"; 
        }
    }
}
