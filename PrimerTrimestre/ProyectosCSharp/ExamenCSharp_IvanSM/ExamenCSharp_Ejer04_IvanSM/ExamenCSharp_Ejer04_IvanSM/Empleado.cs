using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCSharp_Ejer04_IvanSM
{
    internal class Empleado
    {
        // Atributos
        private String nombre;
        private int numHorasExtra;
        private double salarioSinExtras;

        // Constructores
        public Empleado(string nombre, double salarioSinExtras)
        {
            this.nombre = nombre;
            this.numHorasExtra = 0;
            this.salarioSinExtras = salarioSinExtras;
        }

        // Getters and Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumHorasExtra { get => numHorasExtra; set => numHorasExtra = value; }
        public double SalarioSinExtras { get => salarioSinExtras; set => salarioSinExtras = value; }

        // Metodos
        public int hacerHorasExtra(int horasExtras)
        {
            int totalHorasExtras = horasExtras + this.numHorasExtra;
            return totalHorasExtras;
        }

        public int calcularSalarioTotal(double salarioSinExtra)
        {
            double salarioTotal = salarioSinExtra  + (25 * this.numHorasExtra);
            return 0;
        }


    }
}
