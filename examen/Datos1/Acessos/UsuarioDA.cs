using Datos1.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1.Acessos
{
    public class UsuarioDA
    {
        readonly string  cadena = "Server=localhost; Port=3306; Database=ejercicio; Uid=root; Pwd=123456;";
        MySqlConnection conn;
        MySqlCommand cmd;
       // private string codigoUsuario;
       // private string Nombre;

       // public string Contraseña { get; private set; }

        public Usuario Login(string codigoUsuario, string Contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE codigoUsuario = @codigoUsuario AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.codigoUsuario = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Contraseña = reader[2].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }
        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaUsuariosDT;
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuario VALUES (@codigoUsuario, @Nombre, @Contraseña);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codigoUsuario", usuario.codigoUsuario);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }



    }
}
