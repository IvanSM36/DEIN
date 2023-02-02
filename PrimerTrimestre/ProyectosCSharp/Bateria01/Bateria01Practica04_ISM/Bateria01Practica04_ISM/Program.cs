// See https://aka.ms/new-console-template for more information
// Realiza un programa en C# que calcule el perímetro de un cuadrado, pidiendo al usuario
// antes que introduzca el valor de un lado.

Console.Write("Introduzca el tamaño de un lado del cuadrado: ");
int lado = int.Parse(Console.ReadLine());
int calcularPerimetro = lado * 4;
Console.Write("El perimetro del cuadrado con " + lado + "cm de lado es:" + calcularPerimetro + "cm.");