using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Crea una función que devuelva la posición del número menor de un array. Los valores de este
 * array se definen en el código directamente. 
 */

namespace Bateria03Practica09_ISM
{
    internal class Program
    {
        // Funcion
        public static int menorDelArray(int[] num)
        {
            int resultado = 0;

            for(int i = 0; i < num.Length; i++)
            {
                resultado = num[i];
                if(resultado < num[i])
                {
                    resultado = num[i];
                }
            }

            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa devuelve la posicion del numero menor de un array.");

            int[] numeros = { 5, 7, 23, 50, 21, 36, 4, 10, 75, 3 };

            int resultado = menorDelArray(numeros);
            Console.WriteLine("El menor del array es: " + resultado);
        }
    }
}
