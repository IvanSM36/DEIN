using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Crea un programa en C#, que mediante el uso de una función auxiliar, calcule la suma de los
 * dígitos individuales de un número que el usuario introduce por teclado. Por ejemplo, si el
 * usuario introduce el número 23, el resultado debe ser 2+3=5.
*/

namespace Bateria03Practica08_ISM
{
    internal class Program
    {
        public static int sumarDigitos(int num)
        {
            int suma = 0;
            while(num != 0)
            {
                suma += num % 10;
                num /= 10;
            }
            return suma;
        }

        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Este programa suma los dos digitos de un numero de 2 cifras.");

            do
            {
                Console.Write("Introduzca un numero de dos cifras: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 10);

            int resultado = sumarDigitos(num);

            Console.WriteLine("Numero introducido: " + num + " la suma de los digitos es: " + resultado );
        }
    }
}
