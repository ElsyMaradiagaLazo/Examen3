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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox1.Text,ContraseñatextBox2.Text);
           // UsuarioVista usuarioVista = new UsuarioVista();
            //usuarioVista.Show();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
