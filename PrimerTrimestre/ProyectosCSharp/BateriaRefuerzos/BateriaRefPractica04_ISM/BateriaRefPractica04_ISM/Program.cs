using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Desarrolla una clase CD con los siguientes atributos:
 *      o canciones: un array de objetos de la clase Cancion.
 *      o contador: la siguiente posición libre del array canciones. y los siguientes métodos:
 *      o CD(): constructor predeterminado (creará el array canciones).
 *      o numeroCanciones(): devuelve el valor del contador de canciones.
 *      o dameCancion(int): devuelve la Cancion que se encuentra en la posición indicada.
 *        grabaCancion(int, Cancion): cambia la Cancion de la posición indicada por la nueva
 *        Cancion proporcionada.
 *      o agrega(Cancion): agrega al final del array la Cancion proporcionada.
 *      o elimina(int): elimina la Cancion que se encuentra en la posición indicada.
 */

namespace BateriaRefPractica04_ISM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CD album = new CD();

            Cancion c1 = new Cancion("La Bruja", "Darell");
            Cancion c2 = new Cancion("Just in Cas", "Timmy Trumpet ");

            album.agrega(c1);
            album.agrega(c2);

            Console.WriteLine("");

            Console.WriteLine("Numero de canciones en el album: " + album.numeroCanciones());

            album.dameCancion(1);


           // album.elimina(c2);

        }
    }
}
