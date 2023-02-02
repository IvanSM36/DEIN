using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCSharp_Ejer04_IvanSM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            String user = "2DAM";
            String pass = "2DAM";
            Empleado e = null;
            MisEmpleados misEmpleados = null;

            do
            {
                Console.WriteLine("********************Bienvenidos a OsunaTech S.L.********************");
                Console.WriteLine("ADMINISTRACIÓN");
                Console.WriteLine("     1) Dar de alta nuevo empleado");
                Console.WriteLine("     2) Calcular horas extra totales de todos los empleados");
                Console.WriteLine("     3) Mostrar informe de todos los empleados");
                Console.WriteLine();
                Console.WriteLine("EMPLEADOS");
                Console.WriteLine("     4) Insertar hora extra");
                Console.WriteLine("********************************************************************");

                Console.Write("Introduzca una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        //Pedimos usuario y contraseña si no es la correcta la volvera a pedir.
                        do
                        {
                            Console.Write("Introduzca nombre usuario: ");
                            user = Convert.ToString(Console.ReadLine());
                            Console.Write("Introduzca contraseña: ");
                            pass = Convert.ToString(Console.ReadLine());

                            if(!user.Equals("2DAM") || !pass.Equals("2DAM"))
                            {
                                Console.WriteLine("Error, usuario o contraseña incorrecta.");
                            }
                            else
                            {
                                Console.Write("Introduzca tu nombre: ");
                                String nombre = Convert.ToString(Console.ReadLine());
                                Console.Write("Introduzca salario: ");
                                double salario = Convert.ToDouble(Console.ReadLine());

                                // Creamos el objeto empleado
                                e = new Empleado(nombre, salario);
                                // Agregamos al array
                                misEmpleados.anadirEmpleado(e);
                            }

                        } while (!user.Equals("2DAM") || !pass.Equals("2DAM"));

                        break;
                    case 2:
                        Console.Write("Introduzca nombre usuario: ");
                        user = Convert.ToString(Console.ReadLine());
                        Console.Write("Introduzca contraseña: ");
                        pass = Convert.ToString(Console.ReadLine());

                        if (!user.Equals("2DAM") || !pass.Equals("2DAM"))
                        {
                            Console.WriteLine("Error, usuario o contraseña incorrecta.");
                        }
                        else
                        {
                        }
                        break;
                    case 3:
                          do
                        {
                            Console.Write("Introduzca nombre usuario: ");
                            user = Convert.ToString(Console.ReadLine());
                            Console.Write("Introduzca contraseña: ");
                            pass = Convert.ToString(Console.ReadLine());

                            if(!user.Equals("2DAM") || !pass.Equals("2DAM"))
                            {
                                Console.WriteLine("Error, usuario o contraseña incorrecta.");
                            }
                            else
                            {
                                misEmpleados.mostrarEmpleados();
                            }

                        } while (!user.Equals("2DAM") || !pass.Equals("2DAM"));
                        break;
                    case 4:

                        break;
                    case 0:
                        Console.WriteLine("Fin del programa.");
                        break;
                    default:
                        Console.WriteLine("Por favor introduzca una opcion entre 0 - 4");
                        break;
                }
            } while (opcion != 0);
        }
            
    }
}
