// See https://aka.ms/new-console-template for more information
/*
 * Crea un programa para calcular el factorial de un número que el usuario introduce por
 * teclado. Nota: por ejemplo, el factorial de 4 es 4x3x2x1=24. El factorial de 3 es 3x2x1=6.
 */

// Variables
int factorial = 1;

Console.Write("Introduzca un numero: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine("El factorial de " + num + " es: " + factorial);
