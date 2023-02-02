using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCSharp_Ejer04_IvanSM
{
    internal class MisEmpleados
    {
        // Atributos
        Empleado[] empleados = new Empleado[15];

        public MisEmpleados(Empleado[] e)
        {
            this.empleados = e;
        }

        // Getters and Setters
        internal Empleado[] Empleados { get => empleados; set => empleados = value; }

        // Metodos

        public void anadirEmpleado(Empleado e)
        {

            for (int i = 0; i < empleados.Length; i++)
            {
                if ((empleados[i].Nombre.Equals(" ")))
                {
                    empleados[i] = e;
                    i = empleados.Length - 1;
                }
                else if ((empleados[i].Nombre == e.Nombre))
                {
                    Console.WriteLine("No se puede repetir nombres");
                    i = empleados.Length - 1;
                }
            }
        }

        public void mostrarEmpleados()
        {
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("Nombre: " + empleados[i].Nombre + " Salario: " + empleados[i].SalarioSinExtras + " Horas extras: " + empleados[i].NumHorasExtra + " Salario total: " ); 
            }
        }

      
    }
}
