// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que, tras solicitar al usuario un número del 1 al 9 (comprueba que el
 * número no está fuera del rango), muestre por pantalla la tabla de multiplicar de ese número.
 * Cada línea tendrá que tener este formato, por ejemplo: “8 x 3 = 24”
 */

//Variables
int num = 0;

do
{
    Console.Write("Introduzca un numero del 1 al 9: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 && num <= 9)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
    else if (num > 9)
    {
        Console.WriteLine("Por favor introduzca un numero entre 1 y 9");
    }
    else
    {
        Console.WriteLine("Se ha cerrado el programa correctamente.");
    }
}
while(num >= 1 && num <= 9);

