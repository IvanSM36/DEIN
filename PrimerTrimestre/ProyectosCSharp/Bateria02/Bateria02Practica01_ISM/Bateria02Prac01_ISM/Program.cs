// See https://aka.ms/new-console-template for more information
/*
 * Crea una aplicación que pida al usuario dos números, y que muestre por pantalla cuál de los
 * dos es mayor. La salida tienes que implantarla en una sola línea de “WriteLine” y sin utilizar
 * concatenaciones. 
 */

Console.Write("Introduzca un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduzca el segundo numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"El mayor es: {Math.Max(num, num2)} ");
