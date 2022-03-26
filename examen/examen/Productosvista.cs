using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos1;
using Datos1.Acessos;
using Datos1.Entidades;

namespace examen
{
    public partial class Productosvista : Form
    {
        public Productosvista()
        {
            InitializeComponent();
        }

        productoDA productoDA = new productoDA();
        string operacion = string.Empty;

        private void Productosvista_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
        private void HabilitarControles()
        {
            CodigoProductotextBox1.Enabled = true;
            DescripciontextBox2.Enabled = true;
            PreciotextBox3.Enabled = true;
            ExistenciatextBox4.Enabled = true;

            Guardarbutton2.Enabled = true;
            Cancelarbutton3.Enabled = true;
            Nuevobutton1.Enabled = false;

        }
        private void DesabilitarControles()
        {
            CodigoProductotextBox1.Enabled = false;
            DescripciontextBox2.Enabled = false;
            PreciotextBox3.Enabled = false;
            ExistenciatextBox4.Enabled = false;

            Guardarbutton2.Enabled = false;
            Cancelarbutton3.Enabled = false;
            Nuevobutton1.Enabled = true;


        }
        private void LimpiarControles()
        {
            CodigoProductotextBox1.Clear();
            DescripciontextBox2.Clear();
            PreciotextBox3.Clear();
            ExistenciatextBox4.Clear();

        }
        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void Guardarbutton2_Click(object sender, EventArgs e, ErrorProvider errorProvider)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoProductotextBox1.Text))
                {
                    errorProvider.SetError(CodigoProductotextBox1, "Ingrese el código");
                    CodigoProductotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripciontextBox2.Text))
                {
                    errorProvider.SetError(DescripciontextBox2, "Ingrese una descripción");
                    DescripciontextBox2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PreciotextBox3.Text))
                {
                   errorProvider.SetError(PreciotextBox3, "Ingrese un precio");
                    PreciotextBox3.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciatextBox4.Text))
                {
                    errorProvider.SetError(ExistenciatextBox4, "Ingrese una existencia");
                    ExistenciatextBox4.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.codigo = CodigoProductotextBox1.Text;
                producto.Descripcion = DescripciontextBox2.Text;
                producto.Precio = Convert.ToDecimal(PreciotextBox3.Text);
                producto.Existencia = Convert.ToInt32(ExistenciatextBox4.Text);
                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
        }
            catch (Exception)
            {
            }

        }
        private void ListarProductos()
        {
            productosLdataGridView1.DataSource = productoDA.ListarProductos();
        }
        private void PrecioTextBox3_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
               e.Handled = true;
             errorProvider1.SetError(PreciotextBox3, "Ingrese un caracter numerico");

           }
           if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
               e.Handled = true;
           }
        }
     private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
       {
          if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
           {
               e.Handled = true;
           }

        }


    }
}
