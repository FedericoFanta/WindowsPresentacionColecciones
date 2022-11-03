using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProductos
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellido)
        {
            Id=id;
            Nombre=nombre;
            Apellido=apellido;
            comision=33;
            



        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static decimal comision;
        public static decimal Comision
        {
            get { return comision; }
        }
    }
}
