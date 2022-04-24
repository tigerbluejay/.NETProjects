using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelos;
using Datos.Servidor;
using System.Data.SqlClient;

namespace Datos.Consultas
{
    public class DacShipper
    {
        public static List<Shipper> Listar()
        {
            string query = "SELECT ShipperId, CompanyName, Phone FROM dbo.Shippers";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<Shipper> shippers = new List<Shipper>();
            while (reader.Read())
            {
                shippers.Add(
                    new Shipper()
                    {
                        ShipperId = reader["ShipperId"].ToString(),
                        CompanyName = reader["CompanyName"].ToString(),
                        Phone = reader["Phone"].ToString()
                    });
            }
            BaseDatosNorthwind.ConectarDB().Close();
            reader.Close();
            return shippers;
        }
        public static List<Shipper> Listar(string shipperId)
        {
            string query = "SELECT ShipperId, CompanyName, Phone FROM dbo.Shippers WHERE @ShipperId = ShipperId";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());
            cmd.Parameters.Add("@ShipperId", System.Data.SqlDbType.Char, 2).Value = shipperId;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            List<Shipper> shippers = new List<Shipper>();
            while (reader.Read())
            {
                shippers.Add(
                    new Shipper()
                    {
                        ShipperId = reader["ShipperId"].ToString(),
                        CompanyName = reader["CompanyName"].ToString(),
                        Phone = reader["Phone"].ToString()
                    });
            }
            BaseDatosNorthwind.ConectarDB().Close();
            reader.Close();
            return shippers;
        }
    }
}