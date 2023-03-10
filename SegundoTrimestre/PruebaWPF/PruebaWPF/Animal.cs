using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWPF
{
    public class Animal
    {

        //Atributos
        int id;
        String raza;
        float precio;
        int stockA;
        String sexo;

        //Constructor

        public Animal()
        {
 
        }

        public Animal(int id, string raza, float precio, int stockA, string sexo)
        {
            this.id = id;
            this.raza = raza;
            this.precio = precio;
            this.stockA = stockA;
            this.sexo = sexo;
        }

        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Raza { get => raza; set => raza = value; }
        public float Precio { get => precio; set => precio = value; }
        public int StockA { get => stockA; set => stockA = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public String datosAnimal()
        {
            String datos;
            datos = "ID: " + Id+ "\nRaza: " + Raza+ "\nSexo: " + Sexo+ "\nStock: " + StockA + "\nPrecio: " + Precio;
            return datos;
        }
        

    }

}
