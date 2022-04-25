using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Datos.Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Consultas
{
    public static class DacStore
    {
        /// <summary>
        /// Usa modelo conectado para traer todas las tiendas
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Usa modelo conectado para traer todas las tiendas por estado
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
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

        public static int Insertar(Store store)
        {
            string query = "INSERT INTO dbo.stores(stor_id,stor_name,stor_address,city,state,zip) VALUES(@stor_id, @stor_name,@stor_address, @city, @state, @zip)";
            SqlCommand cmd = new SqlCommand(query, BaseDatosPubs.ConectarDB());
            cmd.Parameters.Add("@stor_id", SqlDbType.Char, 4).Value = store.StoreId;
            cmd.Parameters.Add("@stor_name", SqlDbType.VarChar, 40).Value = store.StoreName;
            cmd.Parameters.Add("@stor_address", SqlDbType.VarChar, 40).Value = store.StoreAddress;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = store.City;
            cmd.Parameters.Add("@state", SqlDbType.Char, 2).Value = store.State;
            cmd.Parameters.Add("@zip", SqlDbType.Char, 5).Value = store.Zip;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosPubs.ConectarDB().Close();

            return filasAfectadas;

        }

        public static int Modificar(Store store)
        {
            string query = "UPDATE dbo.stores SET stor_name=@stor_name, stor_address=@stor_address, city=@city, state=@state, zip=@zip WHERE stor_id = @stor_id";
            SqlCommand cmd = new SqlCommand(query, BaseDatosPubs.ConectarDB());

            cmd.Parameters.Add("@stor_id", SqlDbType.Char, 4).Value = store.StoreId;
            cmd.Parameters.Add("@stor_name", SqlDbType.VarChar, 40).Value = store.StoreName;
            cmd.Parameters.Add("@stor_address", SqlDbType.VarChar, 40).Value = store.StoreAddress;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = store.City;
            cmd.Parameters.Add("@state", SqlDbType.Char, 2).Value = store.State;
            cmd.Parameters.Add("@zip", SqlDbType.Char, 5).Value = store.Zip;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosPubs.ConectarDB().Close();
            return filasAfectadas;
        }

        public static int Eliminar(string id)
        {
            string query = "DELETE FROM dbo.stores WHERE stor_id=@stor_id";
            SqlCommand cmd = new SqlCommand(query, BaseDatosPubs.ConectarDB());

            cmd.Parameters.Add("@stor_id", SqlDbType.Char, 4).Value = id;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosPubs.ConectarDB().Close();

            return filasAfectadas;

        }
    }
}
