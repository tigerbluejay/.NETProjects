using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Datos.Servidor;
using System.Data.SqlClient;

namespace Datos.Consultas
{
    public static class DacStore
    {
        public static List<Store> Listar()
        {
            string query = "SELECT stor_id, stor_name, stor_address, city,state,zip FROM dbo.stores";
            SqlCommand cmd = new SqlCommand(query, BaseDatosPubs.ConectarDB());
            // cmd.Parameters.Add("@state", System.Data.SqlDbType.Char, 2).Value = state;


            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<Store> stores = new List<Store>();
            while (reader.Read())
            {
                stores.Add(
                    new Store()
                    {
                        StoreId = reader["stor_id"].ToString(),
                        StoreName = reader[1].ToString(),
                        StoreAddress = reader["stor_address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString()
                    });
            }
            BaseDatosPubs.ConectarDB().Close();
            reader.Close();

            return stores;
        }

        public static List<Store> Listar(string state)
        {
            string query = "SELECT stor_id, stor_name, stor_address, city,state,zip FROM dbo.stores WHERE @state = state";
            SqlCommand cmd = new SqlCommand(query, BaseDatosPubs.ConectarDB());
            cmd.Parameters.Add("@state", System.Data.SqlDbType.Char, 2).Value = state;


            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<Store> stores = new List<Store>();
            while (reader.Read())
            {
                stores.Add(
                    new Store()
                    {
                        StoreId = reader["stor_id"].ToString(),
                        StoreName = reader[1].ToString(),
                        StoreAddress = reader["stor_address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString()
                    });
            }
            BaseDatosPubs.ConectarDB().Close();
            reader.Close();

            return stores;
        }
    }
}
