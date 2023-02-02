using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica05_ISM
{
    internal class Juego
    {
        // Atributos
        private int vidas;
         
        // Constructores
        public Juego(int vidas)
        {
            this.vidas = vidas;
        }

        // Getters and Setters
        public int Vidas { get => vidas; set => vidas = value; }

        // Metodos

        /*
         * Metodo que muestra las vida que tiene el jugador
         * @param null
         * @return int 
         */
        public int MuestraVidasRestantes()
        {
            int vidas = this.vidas;
            return vidas;
        }

        /*
         * Metodo que quita una vida
         * @param null
         * @return null
         */
        public void quitarVida()
        {
            this.vidas -= 1;
        }
    }
}
