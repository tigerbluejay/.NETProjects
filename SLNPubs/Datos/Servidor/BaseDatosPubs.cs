using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.Servidor
{
    internal static class BaseDatosPubs
    {
        internal static SqlConnection ConectarDB()
        {
            string cadenaConexion = Properties.Settings.Default.KeyDbPubs;
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            return connection;
        }
    }
}
