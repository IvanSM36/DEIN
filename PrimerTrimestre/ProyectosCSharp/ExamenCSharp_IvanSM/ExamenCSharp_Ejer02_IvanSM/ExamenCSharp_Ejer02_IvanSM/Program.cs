using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCSharp_Ejer02_IvanSM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Pedimos los datos
            Console.WriteLine("Introduzca numero de filas: ");
            int fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca numero de filas: ");
            int columna = Convert.ToInt32(Console.ReadLine());
            
            // Declaramos el array con el tamaño indicado por teclado(fila)
            int[,] a1 = new int[fila,fila];
            int[,] traspuesta = new int[fila, fila];

            int i, j;
            // Hacemos un arrayque creara tantos arrays como se haya indicado por teclado(Columna)
            Console.WriteLine("La matriz aleatoria generada es: ");

            // Creamos array con numeros randoms 
            for (i = 0; i < columna; i++)
            {
                Console.WriteLine();
                for(j = 0; j < fila; j++)
                {
                    a1[j,i] = random.Next(0, 100); // Lo rellenamos con numeros randoms.
                    Console.Write("\t" + a1[j,i]); //Mostramos el contenido
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("La matriz transpuesta es: ");

            // Pasamos los valores al otro array para cambiar de posicion los numeros 
            for (i = 0; i < columna; i++)
            {
                Console.WriteLine();// salto de linea 
                for ( j = 0; j < fila; j++)
                {
                    traspuesta[i,j] = a1[i,j]; // Paso los datos de l array original al traspuesto y cambio la posicion
                    Console.Write("\t" + traspuesta[i,j]);    
                }
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
