using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1.Entidades
{
    public class Producto
    {
        public string codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, decimal precio, int existencia)
        {
            this.codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
