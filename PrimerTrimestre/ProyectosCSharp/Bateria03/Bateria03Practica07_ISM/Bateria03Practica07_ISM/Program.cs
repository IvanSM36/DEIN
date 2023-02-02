using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Crea un programa que pida dos número enteros al usuario y diga si alguno de ellos es
 * múltiplo del otro. Crea una función EsMultiplo que reciba los dos números, y devuelve si el
 * primero es múltiplo del segundo
*/

namespace Bateria03Practica07_ISM
{
    internal class Program
    {
        // Funcion
        public static Boolean esMultiplo(int num, int num2)
        {
            if (num % num2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Este programa indica si dos numeros son multiplos entre ello.");
            Console.Write("Introduzca un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Boolean resultado = esMultiplo(num, num2);
            if (resultado)
            {
                Console.WriteLine(num + " es multiplo de " + num2);    
            }else
            {
                Console.WriteLine(num + " no es multiplo de " + num2);
            }
        }
    }
}
