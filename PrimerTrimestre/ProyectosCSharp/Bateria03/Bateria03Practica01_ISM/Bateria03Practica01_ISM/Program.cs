// See https://aka.ms/new-console-template for more information

/*
 * Crea una aplicación que, en primer lugar, pida al usuario que introduzca el tamaño del array
 * de enteros a crear, y a continuación proceda a solicitarle al usuario el valor de cada uno de
 * esos componentes del array. Finalmente, muestra por pantalla la suma y la media de todos los
 * valores del array
 */

// Variables
int suma = 0;
double media = 0;
int i = 0;

// Pedimos el tamaño del array
Console.Write("Introduzca tamaño del array: ");
int tamanioArray = Convert.ToInt32(Console.ReadLine());

// Con un for pedimos los valores del array con el tamaño indicado antes
for (i = 0; i < tamanioArray; i++)
{
    Console.Write("Introduzca valor de la posicion " + i + " del array: ");
    int valor = Convert.ToInt32(Console.ReadLine());
    // Sumamos todo los valores
    suma += valor;
}
// Calculamos la media
media = suma / i;

// Mostramos por pantalla los resultados
Console.WriteLine("Suma total = " + suma);
Console.WriteLine("Media = " + media.ToString("N2"));