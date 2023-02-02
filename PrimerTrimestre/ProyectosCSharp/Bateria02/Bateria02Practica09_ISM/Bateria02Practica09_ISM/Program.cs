// See https://aka.ms/new-console-template for more information

/*
 * Desarrolla una aplicación que cree un array de enteros del tamaño que indique el usuario. A
 * mostrará por pantalla qué valores del array son pares y cuáles impares
*/

// Variables

int[] miArray;
int aux = 0;

Console.WriteLine("Este programa crea un array y muestra los pares y los impares");
Console.Write("Introduzca el tamaño del array: ");
int tamañoArray = Convert.ToInt32(Console.ReadLine());

// Declaramos el array con el tamaño recogido por teclado 
miArray = new int[tamañoArray];

// Rellenamos el array
for (int i = 0; i < miArray.Length; i++ )
{
    Console.Write("Introduzca el valor de la posicion " + i + " del array: ");
    int valor = Convert.ToInt32(Console.ReadLine());
    miArray[i] = valor;
}

    // Comprobamos si es par o no 
    for (int i = 0; i != miArray.Length; i++)
{
    if (miArray[i] % 2 == 0)
     {       
         // Mostramos el resultado
         Console.WriteLine(miArray[i] + " par.");
        aux++;
     }
    else
     {
         Console.WriteLine(miArray[i] + " impar");
     }
    
}

   




