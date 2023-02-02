// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduzca un numero: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 5 && num <= 10)
{
    Console.WriteLine("Aprobado");
}else if(num == 0 && num < 5)
{
    Console.WriteLine("Suspenso");
}
else
{
    Console.WriteLine("Error, por favor introduzca un numero entre 0 y 10");
