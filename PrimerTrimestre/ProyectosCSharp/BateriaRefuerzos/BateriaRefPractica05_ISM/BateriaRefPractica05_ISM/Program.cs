using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica05_ISM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramos los objetos juego y le damos 5 vidas
            Juego j1 = new Juego(5);
            Juego j2 = new Juego(5);
            
            //Mostramos las vidas
            Console.WriteLine("Vida inicial del j1: " + j1.MuestraVidasRestantes());
            Console.WriteLine("Vida inicial del j2: " + j2.MuestraVidasRestantes());

            Console.WriteLine();

            //Quitamos 1 vida al jugador1
            j1.quitarVida();

            //Volvemos a mostrar las vidad de los jugadores
            Console.WriteLine("Vida actual: " + j1.MuestraVidasRestantes());
            Console.WriteLine("Vida actual: " + j2.MuestraVidasRestantes());
        }
    }
}
