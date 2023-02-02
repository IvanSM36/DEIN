using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BateriaRefPractica02_ISM
{
    internal class AgendaContacto
    {
        // Atributos
        Contacto[] agenda = new Contacto[10];

        // Constructor
        public AgendaContacto()
        {

        }

        public AgendaContacto(Contacto[] agenda)
        {
            this.agenda = agenda;
        }

        // Getters and Setters.

        internal Contacto[] Agenda { get => agenda; set => agenda = value; }


        // Metodos
        public void crearAgenda()
        {
            Contacto vacio = new Contacto("", 0);
            for (int i = 0; i < agenda.Length; i++)
            {
                agenda[i] = vacio;
            }
        }

        /*
        * Metodo para añadir un contacto al array
        * @param Contacto objeto
        * @return null
        */
        public void anadirContacto(Contacto c)
        {

            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre == ""))
                {
                    agenda[i] = c;
                    i = agenda.Length - 1;
                }
                else if ((agenda[i].Nombre == c.Nombre))
                {
                    Console.WriteLine("No se puede repetir nombres");
                    i = agenda.Length - 1;
                }
            }
        }

        /*
        * Metodo para listar todos los contactos del array
        * @param null
        * @return null
        */
        public void listarAgenda()
        {
            for (int i = 0; i < agenda.Length; i++)
            {
                Console.WriteLine("Nombre: " + agenda[i].Nombre + " teléfono: " + agenda[i].Telefono); ;
            }
        }

        /*
        * Metodo para comprobar si existe un contacto en el array
        * @param String nombre
        * @return null
        */
        public void existeContacto(String nombre)
        {
            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre == nombre))
                {
                    Console.WriteLine("Contacto encontrado");
                    i = agenda.Length - 1;
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado");
                }
            }

        }

        /*
        * Metodo para buscar un contacto del array
        * @param String nombre
        * @return null
        */
        public void buscaContacto(String nombre)
        {
            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre == nombre))
                {
                    Console.WriteLine("Nombre: " + agenda[i].Nombre + " telefono: " + agenda[i].Telefono);
                    i = agenda.Length - 1;
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado");
                }
            }
        }

        /*
        * Metodo para eliminar un contacto del array
        * @param String nombre
        * @return null
        */
        public void eliminarContacto(String nombre)
        {
            Contacto vacio = new Contacto("", 0);
            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre == nombre))
                {
                    agenda[i] = vacio;
                    i = agenda.Length - 1;
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado");
                }
            }
        }

        /*
        * Metodo para indicar si la genda esta llena
        * @param null
        * @return null
        */
        public void agendaLlena()
        {
            int contador = 0;
            Contacto vacio = new Contacto("", 0);
            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre != ""))
                {
                    contador++;
                }
            }

            if (contador == agenda.Length - 1) { Console.WriteLine("Agenda llena"); } else { Console.WriteLine("Agenda no llena"); }
        }

        /*
        * Metodo para indicar cuantos huecos libres quedan
        * @param null
        * @return null
        */
        public void huecosLibres()
        {
            int contador = 0;
            Contacto vacio = new Contacto("", 0);
            for (int i = 0; i < agenda.Length; i++)
            {
                if ((agenda[i].Nombre == ""))
                {
                    contador++;
                }

            }
            Console.WriteLine("Huecos libres: " + contador);
        }

    }
}
