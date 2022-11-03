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
using WindowsPresentacionColecciones.PruebaEstatica;
using LibreriaProductos;

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
            List<Producto> productos = AdminProducto.TraerPorCategoria("Hardware");
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

            //AdminProducto adminProducto = new AdminProducto();

            lista=AdminProducto.Carga();


            gridProductos.DataSource = lista;

            foreach (Producto producto in lista)
            {
                lstPrecioProducto.Items.Add(producto.Nombre + "Precio:" +producto.Precio);  
            }   
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente ("Gaby");
            Cliente cliente2 = new Cliente("Gustavo");

            MessageBox.Show(Cliente.Instancias.ToString());

            Cliente cliente3 = new Cliente("ASD");
            Cliente cliente4 = new Cliente("Alejo");

            MessageBox.Show(Cliente.Instancias.ToString());


        }

        private void btnCrearEmpleados_Click(object sender, EventArgs e)
        {
            Empleado.Comision=3;
            Empleado empleado1 = new Empleado(id:32, nombre:"Pepe", apellido:"Jose");
            Empleado empleado2 = new Empleado(id: 32, nombre: "Ramon", apellido: "Perez");

            MessageBox.Show(Empleado.Comision.ToString());

            Empleado.Comision=66;

            Empleado empleado3 = new Empleado(id: 32, nombre: "Lucas", apellido: "Aerty");
            

            Empleado empleado4 = new Empleado(id: 32, nombre: "Augusto", apellido: "Poliy");

            MessageBox.Show(Empleado.Comision.ToString());
        }
    }
}
