// See https://aka.ms/new-console-template for more information

/*
 * Realiza un programa que calcule el porcentaje de participación de cada socio en una
 * empresa, introduciendo por teclado la cantidad que aporta cada uno de ellos. Para dar la
 * información, utiliza Console.WriteLine incluyendo texto y llaves de sustitución en la misma
 * línea. Por ejemplo, la salida podría ser algo como esto: “El porcentaje del socio 1 es 20%, del
 * socio 2 es 35% y del socio es es 45%”.
 */

// Variables
int sumaTotal = 0;
int porcentajeSocio = 0;
int porcentajeSocio02 = 0;
int porcentajeSocio03 = 0;
int socio = 0;
int socio02 = 0;
int socio03 = 0;

// Pedimos los datos y vamos sumando el total
Console.Write("Introduzca cantidad aportada socio01: ");
socio = Convert.ToInt32(Console.ReadLine());
sumaTotal += socio;

Console.Write("Introduzca cantidad aportada socio02: ");
socio02 = Convert.ToInt32(Console.ReadLine());
sumaTotal += socio02;

Console.Write("Introduzca cantidad aportada socio03: ");
socio03 = Convert.ToInt32(Console.ReadLine());
sumaTotal += socio03;

// Calculamos el porcentaje
porcentajeSocio = (socio * 100) / sumaTotal;
porcentajeSocio02 = (socio02 * 100) / sumaTotal;
porcentajeSocio03 = (socio03 * 100) / sumaTotal;

//Mostramos el resultado.
Console.WriteLine("El porcentaje del socio 1 es: " + porcentajeSocio + " %." + "\nEl porcentaje del socio02 es: " + porcentajeSocio02 + " %." + "\nEl porcentaje del socio 3 es: " + porcentajeSocio03 + " %.");