// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que compruebe si un número que el usuario introduce por teclado es
 * primo o no. Impleméntalo mediante una función. Nota: un número es primo si solo es
 * divisible por sí mismo y por la unidad.
 */

Console.WriteLine("Esta aplicacion indica si el numero introducido es primo o no.");

// Funcion
void comprobarPrimo (int num)
{
    if (num % 2 == 0 && num % num == 0)
    {
        Console.WriteLine("El numero " + num + " es primo");
    }
    else
    {
        Console.WriteLine("El numero " + num + " no es primo");
    }
}


// main
int num = 31;
comprobarPrimo(num);    