using System;

namespace UD06_Tarea01_PruebasUnitarias_IvanSM
{
    public class Programs
    {    

        public static void Main()
        {
            // Instancio los objetos
            Cliente c = new Cliente("Amelio");
            Cliente c2 = new Cliente("Clotilde");

            // Llamo a los metodos para ingresar y retirar saldo al objeto c
            c.ingresarSaldo(1000);
            c.retirarSaldo(500);

            // Llamo a los metodos para ingresar y retirar saldo al objeto c2
            c2.ingresarSaldo(2000);
            c2.retirarSaldo(3000);

            // Llamo al metodo para mostrar toda la informacion de los objetos
            c.mostrarInformacion();
            c2.mostrarInformacion();

        }
    }
}
