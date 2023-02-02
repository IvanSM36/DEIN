// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que muestre el abecedario en mayúsculas, desde la Z a la A (orden
 * inverso). Tienes que realizarlo sabiendo que el código ASCII de la Z es 90 y de la A 65. Pista:
 * debes utilizar Convert.ToString
 */

Console.WriteLine("Este programa muestra el abecedario");


int finLetra = 90;


for (int inicioLetra = 65; inicioLetra <= finLetra; inicioLetra++)
{
    Console.WriteLine(Convert.ToChar(inicioLetra));
}
