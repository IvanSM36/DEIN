// See https://aka.ms/new-console-template for more information

/*
 * Desarrollo un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el
 * cliente. Deberá calcular el coste total
 */

Console.Write("Introduzca el precio del producto: ");
float precio = int.Parse(Console.ReadLine());
Console.Write("Introduzca la cantidad del producto: ");
float cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("Coste total: " + (precio * cantidad) + "€");