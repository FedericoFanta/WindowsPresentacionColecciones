using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPresentacionColecciones.Models;
using WindowsPresentacionColecciones.Colecciones;

namespace WindowsPresentacionColecciones
{
    public partial class Form1 : Form
    {
        //declarar
        List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarAlumnosLista_Click(object sender, EventArgs e)
        {
            /*
            //declarar y crear la lista
            productos = new List<Producto>();


            //crear el objeto de producto
            Producto producto = new Producto() { Nombre = "Teclado", Categoria ="Hardware", Precio=33 };


            //Agregar el producto a la lista
            productos.Add(producto);

            //Agregar otro producto a la coleccion de productos tipo anonimo

            productos.Add(new Producto() {Nombre = "Monitor ", Categoria="Hardware", Precio=555 });
            productos.Add(new Producto() { Nombre = "Impresora ", Categoria="Hardware", Precio=222 });
            */

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Producto> lista;

            AdminProducto adminProducto = new AdminProducto();

            lista=adminProducto.Carga();


            gridProductos.DataSource = lista;

            foreach (Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + "Precio:" +producto.Precio);  
            }   
        }
    }
}
