using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria06Practica06_ISM
{
    internal class Program
    {
        // Funcion 
        public static Boolean login(String user, String pass)
        {
            if (user.Equals("123") && pass.Equals("123"))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {

            for (int i = 3; i >= 0; i--)
            {
                Console.Write("Introduzca nombre de usuario: ");
                String user = Convert.ToString(Console.ReadLine());
                Console.Write("Introduzca contraseña: ");
                String pass = Convert.ToString(Console.ReadLine());

                if (login(user, pass))
                {
                    Console.WriteLine("Has iniciado sesion correctamente.");
                    i = 0;
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecta, te quedan " + i + " intentos");
                }

            }

        }
    }
}
