// See https://aka.ms/new-console-template for more information

/*
 * Crea una aplicación que cuente el número de espacios en blanco existentes en una cadena
 * que el usuario introduce por teclado. Debes implementar una función que reciba como
 * parámetro un string y devuelva el número de caracteres.
 */

Console.WriteLine("Esta aplicacion cuenta los espacios de una cadena de texto.");

// Funcion
int cuentaEspacios(String cadena)
{
    int numEspacios = 0;
    int numCaracteres = 0;

    for(int i = 0; i < cadena.Length; i++)
    {
        if (cadena[i].Equals(' ')){
            numEspacios++;
        }
        else
        {
            numCaracteres++;
        }

    } 
    Console.WriteLine("Contiene " + numEspacios + " espacios");
    return numCaracteres;
}

//Ejecucion de la funcion
String frase = " H o la que tal";
Console.WriteLine("Contiene " + cuentaEspacios(frase) + " caracteres");