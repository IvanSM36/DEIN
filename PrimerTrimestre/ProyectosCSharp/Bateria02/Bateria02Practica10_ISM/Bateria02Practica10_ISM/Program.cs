// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que defina un array de 10 enteros, e inicialice todos los campos con valores
 * desordenados. A continuación utiliza algún método de la clase System.Array para ordenar
 * dicho array, y muestra por pantalla todos los valores ordenados (recorriendo el array de
 * principio a fin mediante un bucle for)
 */

int[] desordenado = new int[10];
Random rand = new Random();
// Rellenamos el array con numeros randoms y lo mostramos
Console.Write("Array desordenado: ");

for (int i = 0; i < desordenado.Length; i++)
{
    desordenado[i] = rand.Next(1, 10);
    Console.Write(" " + desordenado[i]);
}

Console.WriteLine("");

//Recorremos el array y lo ordenamos
Console.Write("Array ordenado:    ");
for (int i = 0; i < desordenado.Length; i++)
{
    Array.Sort(desordenado);
    Console.Write(" " + desordenado[i]);
}
