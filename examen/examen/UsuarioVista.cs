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
    public partial class UsuarioVista : Form
    {
        public UsuarioVista()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();   

        private void UsuarioVista_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
 
        }

        private void ListarUsuarios()
        {
          UsuariosdataGridView1.DataSource=usuarioDA.ListarUsuarios();
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void LimpiarControles()
        {
            CodigotextBox1.Clear();
            NombretextBox2.Text = "";
            ContraseñatextBox3.Text = string.Empty;
        }

        private void HabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;
            ContraseñatextBox3.Enabled = true;

            Nuevobutton1.Enabled = false;
            Agregarbutton1.Enabled = true;
            Cancelarbutton1.Enabled = true;


        }

        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;
            ContraseñatextBox3.Enabled = true;

            Nuevobutton1.Enabled = false;
            Agregarbutton1.Enabled = true;
            Cancelarbutton1.Enabled = true;


        }

        private void Agregarbutton1_Click(object sender, EventArgs e)
        {
            user.codigoUsuario = CodigotextBox1.Text;
            user.Nombre = NombretextBox2.Text;
            user.Contraseña = ContraseñatextBox3.Text;
            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDA.InsertarUsuario(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo Crear");
                }
            }
        }

        private void Cancelarbutton1_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }

}
