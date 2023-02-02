using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria03Practica10_ISM
{
    internal class Cliente
    {
        //Se van a definir dos campos como privados, por lo que solo serán accesibles desde dentro de la clase.
        private string nombre; //almacena el nombre del cliente
        private int cantidadTotal; //almacena la cantidad total que el cliente tiene en su cuenta bancaria

        //Este método se llama automáticamente cuando se crea un objeto. Asignamos el nombre a la variable nombre e inicializamos la cantidad a 0
        public Cliente(string paramNombre)
        {
            nombre = paramNombre;
            cantidadTotal = 0;
        }

        //Mediante este método se simula un ingreso en la cuenta de cliente. Recibirá como parámetro la cantidad total a ingresar, y se sumará a su saldo anterior
        public void Ingresar(int paramCantidad)
        {
            cantidadTotal += paramCantidad;
        }

        //Este método se ha definido de forma abreviada mediante =>, aunque se podría haber definido como el anterior, con la forma clásica. Lo pongo para que veais diferentes formas de definir un método
        //El método recibe como parámetro una cantidad, y la resta del saldo
        public void Sacar(int paramCantidad) => cantidadTotal -= paramCantidad;
        public int CantidadTotal => cantidadTotal; //método abreviado para acceder desde fuera a la variable cantidadTotal

        //Este método muestra la cantidad de dinero que tiene un cliente en su cuenta
        public void MostrarInformacion()
        {
            Console.WriteLine("El usuario {0} tiene en su cuenta {1}", nombre, cantidadTotal);
        }
    }
}
