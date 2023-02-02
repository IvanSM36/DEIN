// See https://aka.ms/new-console-template for more information

/*
 * Escribe un programa en C# que compruebe si un string introducido por el usuario comienza
 * por “www”, en cuyo caso debe devolver “true”
 */

Console.Write("Introduzca una frase: ");
String frase = Convert.ToString(Console.ReadLine());
Boolean empiezaW = false;

if (frase.Substring(0, 3).Equals("www"))
{
    empiezaW = true;
    Console.Write(empiezaW + " empieza por www");
}
else
{
    empiezaW = false;
    Console.Write(empiezaW + " no empieza por www");

}