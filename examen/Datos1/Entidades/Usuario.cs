using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1.Entidades
{
    public class Usuario
    {

        public string codigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contraseña)
        {
            this.codigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
        }
    }
}
