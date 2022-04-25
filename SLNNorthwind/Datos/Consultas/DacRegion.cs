using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelos;
using Datos.Servidor;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Consultas
{
    public static class DacRegion
    {
        /// <summary>
        /// Usa modelo conectado para traer todas las regiones
        /// </summary>
        public static List<Region> Listar()
        {
            string query = "SELECT RegionId, RegionDescription FROM dbo.Region";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<Region> regions = new List<Region>();
            while(reader.Read())
            {
                regions.Add(
                    new Region()
                    {
                        RegionId = (int)reader["RegionId"],
                        RegionDescription = reader["RegionDescription"].ToString()
                    });
            }

            BaseDatosNorthwind.ConectarDB().Close();
            reader.Close();

            return regions;
        }

        public static int Insertar(Region region)
        {
            string query = "INSERT INTO dbo.Region(RegionID,RegionDescription) VALUES (@RegionID, @RegionDescription)";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());
            cmd.Parameters.Add("@RegionID", SqlDbType.Int).Value = region.RegionId;
            cmd.Parameters.Add("@RegionDescription", SqlDbType.VarChar, 40).Value = region.RegionDescription;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosNorthwind.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Modificar(Region region)
        {
            string query = "UPDATE dbo.Region SET RegionDescription = @RegionDescription WHERE RegionId = @RegionId";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());

            cmd.Parameters.Add("@RegionID", SqlDbType.Int).Value = region.RegionId;
            cmd.Parameters.Add("@RegionDescription", SqlDbType.VarChar, 40).Value = region.RegionDescription;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosNorthwind.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Eliminar(int id)
        {
            string query = "DELETE from dbo.Region WHERE RegionID=@RegionID";
            SqlCommand cmd = new SqlCommand(query, BaseDatosNorthwind.ConectarDB());

            cmd.Parameters.Add("RegionID", SqlDbType.Int).Value = id;

            int filasAfectadas = cmd.ExecuteNonQuery();

            BaseDatosNorthwind.ConectarDB().Close();

            return filasAfectadas;
        }
    }
}
