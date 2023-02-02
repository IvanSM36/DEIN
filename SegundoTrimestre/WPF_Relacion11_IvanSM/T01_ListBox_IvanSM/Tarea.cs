using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_ListBox_IvanSM
{
    class Tarea
    {
        //Atributos
        private String descripcion;
        private int prioridad;

        //Constructores

        public Tarea()
        {
        }

        public Tarea(string descripcion, int prioridad)
        {
            this.Descripcion = descripcion;
            this.Prioridad = prioridad;
        }

        //Getter and Setter
        public string Descripcion { get; set; }
        public int Prioridad { get; set; }
    }


}
