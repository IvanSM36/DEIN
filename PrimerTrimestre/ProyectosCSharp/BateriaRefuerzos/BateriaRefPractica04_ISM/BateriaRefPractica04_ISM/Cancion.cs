using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica04_ISM
{
    internal class Cancion
    {
        // Atributos
        private String titulo;
        private String autor;

        // Constructores
        public Cancion()
        {

        }

        public Cancion(String titulo, String autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        // Getters and Setters
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }

        // Metodos

        /*
         * Devuelve el titulo de la canción
         * @param void
         * return String
         */
        public String dameTitulo()
        {
            return titulo;
        }

        /*
        * Devuelve el autor de la canción
        * @param void
        * return String
        */
        public String dameAutor()
        {
            return autor;
        }

        /*
        * Establece el título de la canción.
        * @param String
        * return String
        */
        public void ponTitulo(String titulo)
        {
            this.titulo = titulo;
            Console.WriteLine("Se a establecido el titulo. ");

        }

        /*
        * Establece el autor de la canción.
        * @param String
        * return String
        */
        public void ponAutor(String autor)
        {
            this.autor = autor;
            Console.WriteLine("Se a establecido el autor. ");

        }
    }
}
