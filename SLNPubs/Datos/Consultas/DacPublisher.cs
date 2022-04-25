using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.Servidor;

namespace Datos.Consultas
{
    public static class DacPublisher
    {
        public static DataSet ListarDs()
        {
            string query = "SELECT pub_id, pub_name" +
                "city, state, country FROM dbo.publishers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseDatosPubs.ConectarDB());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "publishers");
            return ds;

        }

        public static DataTable ListarDt()
        {
            string query = "SELECT pub_id, pub_name, city, state" +
                "country FROM dbo.publishers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseDatosPubs.ConectarDB());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "publishers");

            return ds.Tables["publishers"];

        }

        public static DataTable ListarDt(string country)
        {
            string query = "SELECT pub_id,pub_name,city,state, country FROM dbo.publishers WHERE country=@country";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseDatosPubs.ConectarDB());

            adapter.SelectCommand.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = country;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "publishers");
            return ds.Tables["publishers"];
        }

        public static DataTable TraerPaises()
        {
            string query = "SELECT distinct country FROM dbo.publishers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseDatosPubs.ConectarDB());

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Paises");
            return ds.Tables["Paises"];
        }
    }
}
