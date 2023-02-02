using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica04_ISM
{
    internal class CD
    {
        // Atributos
        private Cancion[] canciones;
        const int maxCanciones = 10;

        internal Cancion[] Canciones { get => canciones; set => canciones = value; }

        // Constructores
        public CD()
        {
            canciones = new Cancion[maxCanciones];
        }

        /*
         * Devuelve el valor del contador de canciones.
         * @param null
         * @return int
         */
        public int numeroCanciones()
        {
            int contador = 0;
            for (int i = 0; i < canciones.Length; i++)
            {
                if (canciones[i] != null)
                {
                    contador++;
                }
            }
            return contador;
        }

        /*
        * Devuelve la Cancion que se encuentra en la posición indicada.
        * @param int posicion
        * @return Cancion objeto
        */
        public void dameCancion(int posicion)
        {
            for (int i = 0; i < canciones.Length; i++)
            {
                if ((i == posicion) && canciones[i] != null)
                {
                    Console.WriteLine(canciones[i].dameTitulo());
                }
                if ((i == posicion) && canciones[i] == null)
                {
                    Console.WriteLine("no se ha encontrado ninguna cancion");
                }
            }
        }

        /*
        * Cambia la Cancion de la posición indicada por la nueva Cancion proporcionada
        * @param int Cancion
        * @return null
        */
        public void grabaCancion(int posicion, Cancion c)
        {
            Cancion aux;

            int v = Array.IndexOf(canciones, c);
            aux = canciones[posicion];
            canciones[posicion] = c;
            canciones[v] = aux;

        }

        /*
        * Agrega al final del array la Cancion proporcionada.
        * @param int Cancion
        * @return null
        */
        public void agrega(Cancion c)
        {
            for (int i = 0; i < canciones.Length; i++)
            {
                if (i == canciones.Length - 1)
                {
                    if (canciones[i] == null)
                    {
                        canciones[i] = c;
                        Console.WriteLine("hecho!");
                    }
                    else
                    {
                        Console.WriteLine("ya hay una cancion en esa posicion");
                    }
                }
            }
        }

        /*
        * Elimina la Cancion que se encuentra en la posición indicada.
        * @param int posicion
        * @return null
        */
        public void elimina(int posicion)
        {

        }

    }

}
