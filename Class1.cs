using System;

public class ejercicio91
{
    public struct ProductosMercado
    {
        public int CodigoDeBarras;
        public string NombreProducto;
        public int PrecioProducto;

        public ProductosMercado(int nCodigoDeBarras, string nNombreProducto, int nPrecioProducto)
        {
            CodigoDeBarras = nCodigoDeBarras;
            NombreProducto = nNombreProducto;
            PrecioProducto = nPrecioProducto;
        }
    }
}

namespace ejercicio91
{
    class prod
    {
        public void p()
        {
            ProductosMercado PM;

            
            PM.CodigoDeBarras = 1995;
            PM.NombreProducto = "aguacate";
            PM.PrecioProducto = 25;
            Console.WriteLine("Codigo de Barra: " + PM.CodigoDeBarras + "\nNombre del Producto: "
                              + PM.NombreProducto + "\nPrecio del Producto: " + PM.PrecioProducto);
            Console.ReadKey();
        }
    }
}


