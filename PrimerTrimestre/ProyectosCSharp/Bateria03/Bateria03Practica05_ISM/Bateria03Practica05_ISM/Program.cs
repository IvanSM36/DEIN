using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria03Practica05_ISM
{
    internal class Program
    {

        // Funcion iterativa
        public static int calcularPotencia(int numBase, int expo)
        {
            int resultado = 1;
            for (int i = 0; i < expo; i ++)
            {
                resultado *= numBase;
            }
            return resultado;
        }

        // Funcion recursiva
        public static int potenciaRecursiva(int numBase, int expo)
        {
            int resultado = 0;
            if (expo <= 0)
            {
                return 1;
            }
            else
            {
               return resultado = numBase * potenciaRecursiva(numBase, expo - 1);
            }
          
        }

        /*
        * Crea un programa que calcule la potencia X de un número determinado. El usuario
        * introducirá por teclado tanto la base como el exponente. NO puedes utilizar la clase Math.
        * Impleméntalo de dos formas: iterativa y recursiva.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula la potencia.");
            Console.Write("Introduzca la base: ");
            int numBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Con Funcion iterativa: " + numBase + "^" + exponente + " = " + calcularPotencia(numBase, exponente));
            Console.WriteLine("Con Funcion recursiva: " + numBase + "^" + exponente + " = " + potenciaRecursiva(numBase, exponente));

        }
    }
}
