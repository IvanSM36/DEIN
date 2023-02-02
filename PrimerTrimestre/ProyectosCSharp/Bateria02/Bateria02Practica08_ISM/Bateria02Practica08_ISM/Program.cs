// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que genere un número aleatorio entre 10 y 30. Debes usar para ello la clase
 * Random del sistema
 */

// Variable
int num = 0;
int num2 = 20;
Random random = new Random();

Console.WriteLine("Este programa genera numeros aleatorios entre 10 - 30");


do
{ 
    Console.WriteLine(random.Next(10, 31));   
    num++; 
}while (num <= num2);
