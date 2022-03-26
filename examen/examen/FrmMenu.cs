using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace examen
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        UsuarioVista usuarioVista = null;
        Productosvista productosVista = null;
        PedidosproductoVista pedidosproductoVista = null;   

        private void usuariostoolStripButton1_Click(object sender, EventArgs e)
        {
            if (usuarioVista == null)
            {
                usuarioVista = new UsuarioVista();
                usuarioVista.MdiParent = this;
                usuarioVista.FormClosed += usuarioVista_FormClosed;
                usuarioVista.Show();
            }
            else
            {
                usuarioVista.Activate();
            }
            

        }
        private void usuarioVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            usuarioVista = null;
        }

        private void toolStripTabItem2_Click(object sender, EventArgs e)
        {
            if (productosVista == null)
            {
                productosVista = new Productosvista();
                productosVista.MdiParent = this;
                productosVista.FormClosed += productosVista_FormClosed;
                productosVista.Show();
            }
            else
            {
                productosVista.Activate();
            }

        }
        private void productosVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            productosVista = null;
        }
        private void PedidostoolStripTabItem3_Click(object sender, EventArgs e)
        {
            if (pedidosproductoVista == null)
            {
                pedidosproductoVista = new PedidosproductoVista();
                pedidosproductoVista.MdiParent = this;
                pedidosproductoVista.FormClosed += pedidosproductoVista_FormClosed;
                pedidosproductoVista.Show();
            }
            else
            {
                usuarioVista.Activate();
            }
        }
        private void pedidosproductoVista_FormClosed(object sender, FormClosedEventArgs e)
        {
            pedidosproductoVista = null;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
