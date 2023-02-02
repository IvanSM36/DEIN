using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica01_ISM
{
    internal class Cuenta
    {
        // Atributos
        private String titular;
        private double cantidad;

        // Constructores
        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public Cuenta(String titular, double cantidad)
        {
            this.titular = titular;

            //Si la cantidad es menor que cero, lo ponemos a cero
            if (cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = cantidad;
            }
        }
        
        // Getter and Setter
        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        // Metodos
  
        /*
         * Metodo para ingresar en la cuenta
         * @param double cantidad a ingresar
         * @return null
         */
        public void ingresar(double cantidadIngresar)
        {
            if (cantidadIngresar > 0)
            {
                double total = this.cantidad + cantidadIngresar;
                this.cantidad = total;
            }
        }

        /*
        * Metodo para retirar de la cuenta
        * @param double cantidad a retirar
        * @return null
        */
        public void retirar(double cantidadRetirar)
        {
            if (cantidadRetirar > this.cantidad)
            {
                this.cantidad = 0;
            }
            else
            {
                double total = this.cantidad - cantidadRetirar;
                this.cantidad = total;
            }
        }

        public String toString()
        {
            String toString = "Titular= " + this.titular + " cantidad= " + this.cantidad;
            return toString;
        }
    }
}
