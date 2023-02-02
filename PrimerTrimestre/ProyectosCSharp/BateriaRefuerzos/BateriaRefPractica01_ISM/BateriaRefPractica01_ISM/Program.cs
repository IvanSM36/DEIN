using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede
 * tener decimales).El titular será obligatorio y la cantidad es opcional. Crea dos constructores
 * que cumpla lo anterior.
 * Crea sus métodos get, set y toString.
 * Tendrá dos métodos especiales:
 *      o ingresar(double cantidad): se ingresa una cantidad a la cuenta, 
 *        si la cantidad introducida es negativa, no se hará nada.
 *      o retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad
 *        actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
 */

namespace BateriaRefPractica01_ISM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramos 2 objetos cuenta
            Cuenta c = new Cuenta("Ivan");
            Cuenta c2 = new Cuenta("DonIvan", 1530);

            // Llamamos a los metodos e ingresamos y retiramos dinero
            c.ingresar(150);
            c2.retirar(30);

            // Mostramos el contenido de los objetos
            Console.WriteLine(c.toString());
            Console.WriteLine(c2.toString());
        }
    }
}
