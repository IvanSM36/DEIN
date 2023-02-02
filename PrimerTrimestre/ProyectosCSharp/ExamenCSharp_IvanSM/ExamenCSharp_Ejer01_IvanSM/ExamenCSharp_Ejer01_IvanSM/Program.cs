using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCSharp_Ejer01_IvanSM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicion = 0;
            char letra = ' ';
            int dni = 0;    
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            Console.Write("Introduzca DNI sin letra: ");
            dni = Convert.ToInt32(Console.ReadLine());
                     
            posicion = dni % 23;

            for(int i = 0;i< letras.Length;i++) {
                letra = letras[posicion];
            }
            Console.WriteLine(dni+ " " + letra);
        }
    }
}
