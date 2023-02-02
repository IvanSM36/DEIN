using System;

namespace BateriaRefPractica01_ISM
{
    internal class CuentaBase
    {
        // Atributos
        private double cantidad;
        private String titular;

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
    }
}