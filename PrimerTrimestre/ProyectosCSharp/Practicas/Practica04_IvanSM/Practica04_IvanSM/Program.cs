// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa en C# que calcule en un bar el total a pagar a partir de introducir por
 * teclado el número de hamburguesas, papas y bebidas consumidas. El precio se fijará
 * mediante constantes en el código.
 */

const int hamburguesas = 3;
const int papas = 1;
const int bebidas = 1;

int totalPagar = 0;
int cantidad = 0;

Console.Write("¿Cuantas hamburguesas quieres?: ");
cantidad = Convert.ToInt32(Console.ReadLine());
totalPagar += hamburguesas * cantidad;

Console.Write("¿Cuantas papas quieres?: ");
cantidad = Convert.ToInt32(Console.ReadLine());
totalPagar += papas * cantidad;

Console.Write("¿Cuantas bebidas quieres?: ");
cantidad = Convert.ToInt32(Console.ReadLine()); 
totalPagar += bebidas * cantidad;

Console.Write("Total a pagar: " + totalPagar);