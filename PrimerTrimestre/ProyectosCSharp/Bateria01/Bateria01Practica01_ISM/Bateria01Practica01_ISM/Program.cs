// See https://aka.ms/new-console-template for more information

/*
 *Crea un programa en C# que solicite al usuario dos números por teclado. 
 *Deberá mostrar por pantalla la suma, resta, multiplicación y módulo de ambos números.
 */

Console.WriteLine("Introduzca un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca otro numero");
int num2 = Convert.ToInt32(Console.ReadLine());

//Suma
int resultadoSuma = (num + num2);

//Restar
int resultadoResta = (num - num2);

//Multiplica
int resultadoMulti = (num * num2);

//Dividir
int resultadoDiv = (num / num2);

//Modulo
int resultadoMod = (num % num2);

Console.WriteLine("La suma de " + num + " mas " + num2 + " es: " + resultadoSuma);

Console.WriteLine("La resta de " + num + " menos " + num2 + " es: " + resultadoResta);

Console.WriteLine("La multiplicacion de " + num + " por " + num2 + " es: " + resultadoMulti);

Console.WriteLine("La division entre " + num + " y " + num2 + " es: " + resultadoDiv);

Console.WriteLine("El modulo de " + num + " y " + num2 + " es: " + resultadoMod);


