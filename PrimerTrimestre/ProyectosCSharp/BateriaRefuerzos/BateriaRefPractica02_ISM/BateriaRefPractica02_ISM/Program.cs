using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nos piden realizar una agenda telefónica de contactos.
 * Un contacto está definido por un nombre y un teléfono (No es necesario de validar). Un
 * contacto es igual a otro cuando sus nombres son iguales.
 * Una agenda de contactos está formada por un conjunto de contactos (Piensa en que tipo
 * puede ser)
 * Se podrá crear de dos formas, indicándoles nosotros el tamaño o con un tamaño por defecto
 * (10)
 * Los métodos de la agenda serán los siguientes:
 *      o aniadirContacto(Contacto c): Añade un contacto a la agenda, sino se pueden meter
 *        más a la agenda se indicara por pantalla. No se pueden meter contactos que existan,
 *        es decir, no podemos duplicar nombres, aunque tengan distinto teléfono.
 *      o existeContacto(Conctacto c): indica si el contacto pasado existe o no.
 *      o listarContactos(): Lista toda la agenda
 *      o buscaContacto(String nombre): busca un contacto por su nombre y muestra su
 *        teléfono.
 *      o eliminarContacto(Contacto c): elimina el contacto de la agenda, indica si se ha
 *        eliminado o no por pantalla
 *      o agendaLlena(): indica si la agenda está llena.
 *      o huecosLibres(): indica cuantos contactos más podemos meter.
 *        Crea un menú con opciones por consola para probar todas estas funcionalidades
*/

namespace BateriaRefPractica02_ISM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaContacto agenda = new AgendaContacto();
            String nombre;
            int telefono;
            int opcion = 0;

            agenda.crearAgenda();

            //Creamos un bucle do while para que nos muestre el menu
            do
            {
                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Existe contacto");
                Console.WriteLine("4. Buscar contacto");
                Console.WriteLine("5. Elimnar contacto");
                Console.WriteLine("6. Agenda llena");
                Console.WriteLine("7. Huecos en agenda");
                Console.WriteLine("0. Salir");
                Console.WriteLine("");

                Console.Write("Introduzca una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                // Creamosun Switch para llamar a los metodos necesarios segun la opcion elegida
                switch (opcion)
                {
                    case 1:
                        Console.Write("Indrouzca un nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Introduzca numero de telefono: ");
                        telefono = Convert.ToInt32(Console.ReadLine());
                        Contacto c = new Contacto(nombre, telefono);
                        agenda.anadirContacto(c);
                        break;
                    case 2:
                        agenda.listarAgenda();
                        break;
                    case 3:
                        Console.Write("Introduzca el contacto que buscas: ");
                        nombre = Console.ReadLine();
                        agenda.existeContacto(nombre);
                        break;
                    case 4:
                        Console.Write("Introduzca el contacto que buscas: ");
                        nombre = Console.ReadLine();
                        agenda.buscaContacto(nombre);
                        break;
                    case 5:
                        Console.Write("Introduzca el contacto que buscas: ");
                        nombre = Console.ReadLine();
                        agenda.eliminarContacto(nombre);
                        break;
                    case 6:
                        agenda.agendaLlena();
                        break;
                    case 7:
                        agenda.huecosLibres();
                        break;
                    case 0:

                        break;

                }

            } while (opcion != 0);

        }
    }
}
