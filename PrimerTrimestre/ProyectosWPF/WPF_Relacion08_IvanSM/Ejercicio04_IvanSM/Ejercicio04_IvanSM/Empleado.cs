using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04_IvanSM
{
    class Empleado
    {
        private string nombre;
        private int numHorasExtra;
        private int salarioSinExtras;

        public Empleado(string paramNombre, int paramSalario)
        {
            nombre = paramNombre;
            numHorasExtra = 0;
            salarioSinExtras = paramSalario;
        }

        public int getNumHorasExtra => numHorasExtra;
        public string getNombre => nombre;
        public int getSalario => salarioSinExtras;
        public void HaceHoraExtra(int paramNumHoras)
        {
            numHorasExtra += paramNumHoras;
        }
        public int CalculaSalarioTotal() => salarioSinExtras + 25 * numHorasExtra;
    }
}
