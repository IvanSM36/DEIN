// See https://aka.ms/new-console-template for more information

/*
 * Investiga sobre la clase System.Collections.Stack. Utilizándola, crea una pila e introduce
 * varios valores enteros introducido por teclado. A continuación, muestra los valores de esa
 * “Stack” o pila. Finalmente, saca de la pila un par de elementos, y comprueba que al mostrar
 * de nuevo los valores de la pila, los dos primeros han desaparecido.
 */

using System.Collections;

// Creamos e inicializamos un Stack
Stack pringles = new Stack();

// Metemos contenido
pringles.Push("Aire");
pringles.Push("Aire");
pringles.Push("PapaRota01");
pringles.Push("PapaRota02");
pringles.Push("Papa01");
pringles.Push("Papa02");

//Abre el paquete al reves
// Mostramos los valores
foreach (var item in pringles)
{
    Console.WriteLine(item);
}

// Borramos los valores
Console.WriteLine();
pringles.Pop();
pringles.Pop();

// Volvemos a mostrar
foreach (var item in pringles)
{
    Console.WriteLine(item);
}