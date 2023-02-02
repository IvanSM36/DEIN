// See https://aka.ms/new-console-template for more information

/*
 * Realiza un programa en C# que calcule tu nota final en el módulo “Desarrollo de Interfaces”.
 * Dicha calificación se compone de los siguientes porcentajes:
 * Console.WriteLine("Hello, World!");
 */

const double califParciales = 0.5;
const double valorExamen = 0.3;
const double valorTrabajo = 0.2;

Console.Write("Introduzca nota de la primera calificacion parcial: ");
int notaParcial = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduzca nota de la segunda calificacion parcial: ");
int notaParcial2 = Convert.ToInt32(Console.ReadLine());

int calcularParcial = ((notaParcial + notaParcial2) / 2);

Console.Write("Introduzca la nota del examen: ");
int notaExamen = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduzca la nota del trabajo final: ");
int notaTrabajo = Convert.ToInt32(Console.ReadLine());

double notaFinal = ((calcularParcial * califParciales) + (notaExamen * valorExamen) + (notaTrabajo * valorTrabajo));
Console.Write("Nota final: " + notaFinal);