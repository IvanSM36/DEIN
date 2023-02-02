using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Desarrolla una clase Cancion con los siguientes atributos:
 *      o titulo: una variable String que guarda el título de la canción.
 *      o autor: una variable String que guarda el autor de la canción.
 * Los siguientes métodos:
 *      o Cancion(String, String): constructor que recibe como parámetros el título y el autor
 *        de la canción (por este orden).
 *      o Cancion(): constructor predeterminado que inicializa el título y el autor a cadenas
 *        vacías. dameTitulo(): devuelve el título de la canción.
 *      o dameAutor(): devuelve el autor de la canción.
 *      o ponTitulo(String): establece el título de la canción.
 *      o ponAutor(String): establece el autor de la canción
 */

namespace BateriaRefPractica03_ISM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramoslos objetos que queramos
            Cancion c1 = new Cancion("Darell", "La Bruja");
            Cancion c3 = new Cancion();

            Console.WriteLine();
          
            //LLamamos a los metodos 
            Console.WriteLine("Titulo de c1: " + c1.dameTitulo());
            Console.WriteLine("Autor de c1: " + c1.dameAutor());

            Console.WriteLine();

            //No mostrará nada ya que no tiene datos.
            Console.WriteLine("Titulo de c3: "+ c3.dameTitulo());
            Console.WriteLine("Autor de c3: " + c3.dameAutor());

            Console.WriteLine();

            // Establecemos el titulo y el autor en c3
            c3.ponTitulo("Just In Case");
            c3.ponAutor("Timmy Trumpet");

            Console.WriteLine();

            // Volvemos a mostrarlo
            Console.WriteLine("Titulo de c3: " + c3.dameTitulo());
            Console.WriteLine("Autor de c3: " + c3.dameAutor());

        }
    }
}
