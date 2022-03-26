using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1.Entidades
{
    public class Pedidos
    {
        public int id { get; set; }
        public string nombrecliente { get; set; }
        public DateTime fecha { get; set; }
        public decimal subtotal { get; set; }
        public decimal ISV { get; set; }
        public decimal total { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int id, string nombrecliente, DateTime fecha, decimal subtotal, decimal iSV, decimal total)
        {
            this.id = id;
            this.nombrecliente = nombrecliente;
            this.fecha = fecha;
            this.subtotal = subtotal;
            ISV = iSV;
            this.total = total;
        }
    }
}
