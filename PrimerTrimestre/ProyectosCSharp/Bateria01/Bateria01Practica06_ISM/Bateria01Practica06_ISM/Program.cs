// See https://aka.ms/new-console-template for more information

/*
 * Realiza un programa en C# que pida al usuario que introduzca cuatro valores numéricos, y
 * que muestre por pantalla su suma y promedio
 */

Console.Write("Introduzca un numero: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Introduzca el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el tercer numero: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Introduzca el cuarto numero: ");
int num4 = int.Parse(Console.ReadLine());

int calcularSuma = num + num2 + num3 + num4;
int calcularPromedio = calcularSuma / 4;

Console.WriteLine("La suma de todos los numeros introducidos es: " + calcularSuma);
Console.WriteLine("El promedio de los numero introducidos es: " + calcularPromedio);