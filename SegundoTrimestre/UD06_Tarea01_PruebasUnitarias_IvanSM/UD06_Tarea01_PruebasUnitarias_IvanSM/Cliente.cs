using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD06_Tarea01_PruebasUnitarias_IvanSM
{
    public class Cliente
    {
        // Atributos
        private string nombre;
        private double cantidadTotal;

        /// <summary>
        /// Constructor vacio <see cref="CuentaBanco"/> class.
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Constructor con nombre de parametro del objeto <see cref="CuentaBanco"/> class.
        /// </summary>
        /// <param name="nombre">Nombre del CuentaBanco.</param>
        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        /// <summary>
        /// Metodo que ingresa dinero en el banco.
        /// </summary>
        /// <param name="cantidad">Saldo a ingresar.</param>
        public double ingresarSaldo(double cantidad)
        {
            Console.WriteLine("\n--------------");
            Console.WriteLine("Ingresar saldo");
            Console.WriteLine("--------------");
            this.cantidadTotal += cantidad;
            Console.WriteLine("Se ha ingresado: " + cantidad + " \nSaldo total: " + this.cantidadTotal);
            return this.cantidadTotal;
        }

        /// <summary>
        /// Metodo que retira saldo del banco.
        /// </summary>
        /// <param name="cantidad">Saldo a retirar.</param>
        public double retirarSaldo(double cantidad)
        {
            Console.WriteLine("\n-------------");
            Console.WriteLine("Retirar saldo");
            Console.WriteLine("-------------");
            if (cantidad <= this.cantidadTotal)
            {
                this.cantidadTotal -= cantidad;
                Console.WriteLine("Se ha retirado: " + cantidad + " \nSaldo total: " + this.cantidadTotal);
                return this.cantidadTotal;
            }
            else
            {
                Console.WriteLine("No se puede sacar esa cantidad. Fondos insuficientes.");
                return this.cantidadTotal;

            }
        }

        /// <summary>
        /// Metodo que muestra el saldo total.
        /// </summary>
        /// <returns>Double</returns>
        public double saldoTotal
        {
            get { return cantidadTotal; }
        }

        /// <summary>
        /// Metodfo que muestra toda la informacion del CuentaBanco.
        /// </summary>
        public void mostrarInformacion()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Informacion del CuentaBanco");
            Console.WriteLine("-----------------------");
            Console.WriteLine("CuentaBanco: " + this.nombre);
            Console.WriteLine("Cantidad total: " + this.cantidadTotal);
        }
    }
}
