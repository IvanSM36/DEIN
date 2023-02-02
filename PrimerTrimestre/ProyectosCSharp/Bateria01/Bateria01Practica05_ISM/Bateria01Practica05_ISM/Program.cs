// See https://aka.ms/new-console-template for more information
/*
 * Realiza un programa en C# que pida por teclado 4 números, y muestre por pantalla la suma
 * de los dos primeros y el producto del tercero y el cuarto. 
 */

Console.Write("Introduzca un numero: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Introduzca el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el tercer numero: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el cuarto numero: ");
int num4 = int.Parse(Console.ReadLine());

int calcularSuma = num + num2;
int calcularProducto = num3 * num4;

Console.WriteLine("La suma de " + num + " mas " + num2 + " es: " + calcularSuma);
Console.WriteLine("El producto de " + num3 + " y " + num4 + " es: " + calcularProducto);