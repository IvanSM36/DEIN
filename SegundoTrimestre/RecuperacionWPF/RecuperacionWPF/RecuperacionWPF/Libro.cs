using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionWPF
{
   public class Libro
    {
        String titulo;
        String editorial;
        int paginas;
        double precio;
        int ISBN;
        int stock;

        public Libro(string paramTitulo, string paramEditorial, int paramPaginas, double paramPrecio, int paramISBN, int paramStock)
        {
            titulo = paramTitulo;
            editorial = paramEditorial;
            paginas = paramPaginas;
            precio = paramPrecio;
            ISBN = paramISBN;
            stock = paramStock;
        }
        public string getTitulo => titulo;

        public string getEditorial => editorial;

        public int getPagina => paginas;
        public double getPrecio => precio;
        public int getISBN => ISBN;
        public int getStock => stock;
    }
   
}
