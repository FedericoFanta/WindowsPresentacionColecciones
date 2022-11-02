using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPresentacionColecciones.Models;

namespace WindowsPresentacionColecciones.Colecciones
{
    public class AdminProducto
    {
        List<Producto> productos;
        public List<Producto> Carga() 
        {
            //declarar y crear la lista
            productos = new List<Producto>();


            //crear el objeto de producto
            Producto producto = new Producto() { Nombre = "Teclado", Categoria ="Hardware", Precio=33 };


            //Agregar el producto a la lista
            productos.Add(producto);

            //Agregar otro producto a la coleccion de productos tipo anonimo

            productos.Add(new Producto() { Nombre = "Monitor ", Categoria="Hardware", Precio=555 });
            productos.Add(new Producto() { Nombre = "Impresora ", Categoria="Hardware", Precio=222 });
            productos.Add(new Producto() { Nombre = "Corel", Categoria = "Software", Precio = 33 });
            productos.Add(new Producto() { Nombre = "Office", Categoria = "Software", Precio = 22 });


            return productos;
        }


        public List<Producto> TraerPorCategoria(string categoria)
        {
            //TODO Falta programar el método TraerPorCategoria
            return null;
        }

        public int Insertar(Producto producto)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }


        public int Eliminar(Producto producto)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

    }
}
