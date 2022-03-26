using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos1.Entidades;
using MySql.Data.MySqlClient;

namespace Datos1.Acessos
{
   public class PedidoDA 
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=ejercicio; Uid=root; Pwd=123456;";

        MySqlConnection conn;
        MySqlCommand cmd;
        public int InsertarPedidos(Pedidos pedidos)
        {
            int idFactura = 0;
            try
            {
                string sql = "INSERT INTO pedidos (nombrecliente, fecha, subtotal, impuesto, total) VALUES (@nombrecliente, @fecha, @subtotal, @impuesto, @total); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombrecliente", pedidos.nombrecliente);
                cmd.Parameters.AddWithValue("@fecha", pedidos.fecha);
                cmd.Parameters.AddWithValue("@subtotal", pedidos.subtotal);
                cmd.Parameters.AddWithValue("@impuesto", pedidos.ISV);
                cmd.Parameters.AddWithValue("@total", pedidos.total);
                idFactura = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idFactura;
        }
        public bool Insertardetalle(detalle Detalle)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detallefactura (idfactura, Descripcion, cantidad, preciod, total , codigoproducto) VALUES (@idfactura, @descripcion, @cantidad, @preciod, @total, @codigoproducto);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Idfactura", Detalle.Idfactura);
                cmd.Parameters.AddWithValue("@Descripcion", Detalle.Descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Detalle.cantidad);
                cmd.Parameters.AddWithValue("@preciod", Detalle.preciod);
                cmd.Parameters.AddWithValue("@total", Detalle.total);
                cmd.Parameters.AddWithValue("@codigoproducto", Detalle.Codigoproducto);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }
    }

}
