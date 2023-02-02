// See https://aka.ms/new-console-template for more information

/*
 * Realiza una aplicación en C# que pida al usuario que introduzca un número por teclado, y
 * que realice las siguientes operaciones mostrando el resultado: valor absoluto, potencia al
 * cubo, raíz cuadrada, seno, coseno, número máximo, número mínimo. Si la función necesita
 * más de un número como argumento, puedes crear el que quieras por código
 */

// Variables
int num = 0;
int num2 = 0;

//Pedimos los datos
Console.Write("Introduzca un numero: ");
num = Convert.ToInt32(Console.ReadLine());

// Metodo que calcula el valor absoluto
Console.WriteLine("Valor absoluto de: " + num + " es: " + Math.Abs(num));

// Potencia al cubo
Console.WriteLine("Potencia de " + num + "^2 es: " + (num * num));

// Raiz cuadrada
Console.WriteLine("Raiz cuadrada de " + num + " es: " + Math.Sqrt(num).ToString("N2"));

// Seno
Console.WriteLine("El seno de " + num + " es: " + Math.Sin(num));

// Coseno
Console.WriteLine("El coseno de " + num + " es: " + Math.Cos(num));

// Numero maximo
Console.Write("Introduzca un numero para comparar el maximo: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El numero maximo entre " + num +  " y " + num2 + " es: " + Math.Max(num, num2));

// Numero minimo
Console.Write("Introduzca un numero para comparar el minimo: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El numero minimo entre " + num + " y " + num2 + " es: " + Math.Min(num, num2));
