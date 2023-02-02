// See https://aka.ms/new-console-template for more information

/*
 * Realiza un programa que pida al usuario su estado civil abreviado: C, S, V o D (Casad@,
 * solter@, viud@, divorciad@). Mediante una estructura “case”, muestra por pantalla “Tu
 * estado civil es Casad@”, “Tu estado civil es Solter@”, etc... en función de la letra que haya
 * introducido el usuario. Debes controlar mediante el default del case si el usuario no introduce
 * ninguna opción correcta.
 */

Console.Write("Introduzca estado civil(C, S, V, D): ");
char estadoCivil = Char.Parse(Console.ReadLine());

switch (estadoCivil)
{
    case 'C':
        Console.WriteLine("Estado civil: Casad@.");
        break;
    case 'S':
        Console.WriteLine("Estado civil: Solter@.");
        break;
    case 'V':
        Console.WriteLine("Estado civil: Viud@.");
        break;
    case 'D':
        Console.WriteLine("Estado civil: Divorciad@.");
        break;
    default:
        Console.WriteLine("Por favor introduzca C, S, V, o D");
        break;
}
 

