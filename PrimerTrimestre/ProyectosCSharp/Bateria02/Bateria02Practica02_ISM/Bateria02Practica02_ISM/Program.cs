// See https://aka.ms/new-console-template for more information

/*
 * Realiza un programa para calcular el coste de la factura de la luz. Para ello, solicita por
 * teclado al usuario la cantidad de Kilovatios que ha consumido en el período de facturación
 * anterior. El precio del Kilovatio depende de la cantidad consumida: si se consume más de
 * 1800, el coste es de 0,8; si se consume entre 1000 y 1800, el coste es de 0,12; si se consume
 * menos de 1000, el coste es de 0,14. Muestra por pantalla el total a pagar, en el formato
 * adecuado
 */

//Variables
double costeKW = 0;
double costeFactura = 0;

Console.Write("Introduzca cantidad de kW: ");
double kW = Double.Parse(Console.ReadLine());

if (kW > 1800)
{
    costeKW = 0.8;
    costeFactura = kW * costeKW;
}
else if (kW >= 1000 && kW <= 1800)
{
    costeKW = 0.12;
    costeFactura = kW * costeKW;
}
else if (kW < 1000)
{
    costeKW = 0.14;
    costeFactura = kW * costeKW;
}

//ToString para mostrar solo 2 decimales en double
Console.WriteLine("Coste de la Factura: " + costeFactura.ToString("N2"));