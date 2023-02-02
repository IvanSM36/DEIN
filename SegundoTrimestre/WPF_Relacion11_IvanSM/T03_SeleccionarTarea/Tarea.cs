using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_SeleccionarTarea
{
    class Tarea
    {
        //Atributos
        private String descripcion;
        private int prioridad;
        private int nivelRealizacion;

        //Constructores

        public Tarea()
        {
        }

        public Tarea(string descripcion, int prioridad, int nivelRealizacion)
        {
            this.descripcion = descripcion;
            this.prioridad = prioridad;
            this.nivelRealizacion = nivelRealizacion;
        }

        //Getter and Setter
        public String Descripcion { get; set; }
        public int Prioridad { get; set; }
        public int NivelRealizacion { get; set; }
    }


}
