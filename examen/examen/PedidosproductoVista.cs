using Datos1.Acessos;
using Datos1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class PedidosproductoVista : Form
    {
        public PedidosproductoVista()
        {
            InitializeComponent();
        }
        
        productoDA ProductoDA = new productoDA();
        Pedidos pedidos = new Pedidos();
        Producto producto;
        List<detalle> detalleFacturaLista = new List<detalle>();

        decimal subtotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalAPagar = decimal.Zero;
        private void PedidosproductoVista_Load(object sender, EventArgs e)
        {
            detallefacturadataGridView1.DataSource = detalleFacturaLista;
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
               
                DescripciontextBox4.Text = producto.Descripcion;
                CantidadtextBox3.Focus();
            }
            else
            {
                producto = null;
                DescripciontextBox4.Clear();
                CantidadtextBox3.Clear();
            }
        }

       

       
    }
}
