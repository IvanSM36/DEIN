// See https://aka.ms/new-console-template for more information

/*
 * Crea un programa que pida al usuario que introduzca una cadena de texto. A continuación,
 * muestra por pantalla el resultado de realizar varias acciones sobre esta cadena (en C# el tipo
 * string tiene varios métodos útiles, puedes consultar en la documentación de Microsoft), en
 * concreto: longitud, si contiene una determinada subcadena, reemplazo de una letra por otra,
 * conversión todo a mayúsculas, conversión todo a minúsculas, eliminar algún carácter en una
 * posición determinada, obtener una subcadena indicándole posición de inicio y fin.
 */

Console.Write("Introduzca una palabra: ");
String palabra = Convert.ToString(Console.ReadLine());

// Obtiene el numero de caracteres del String
Console.WriteLine("Metodo length: " + palabra + " = " + palabra.Length);

// Reemplaza una letra por otra 
Console.WriteLine("Metodo replace: " + palabra + " = " + palabra.Replace('a', 'e'));

// Conversion a todo en mayusculas
Console.WriteLine("Metodo toUpper: " + palabra + " = " + palabra.ToUpper());

// Conversion a todo en minusculas
Console.WriteLine("Metodo toLower: " + palabra + " = " + palabra.ToLower());

// Eliminar algún carácter
Console.WriteLine("Metodo remove: " + palabra + " = " + palabra.Remove(4));

// Obtener una subcadena indicándole posición de inicio y fin
Console.WriteLine("Metodo remove: " + palabra + " = " + palabra.Substring(4, 3));
