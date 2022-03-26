using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1.Entidades
{
    public class detalle
    {
        public int id { get; set; }
        public int Idfactura { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal preciod { get; set; }
        public decimal total { get; set; }
        public string Codigoproducto { get; set; }

        public detalle()
        {
        }

        public detalle(int id, int idfactura, string descripcion, int cantidad, decimal preciod, decimal total, string codigoproducto)
        {
            this.id = id;
            Idfactura = idfactura;
            Descripcion = descripcion;
            this.cantidad = cantidad;
            this.preciod = preciod;
            this.total = total;
            Codigoproducto = codigoproducto;
        }
    }
}
