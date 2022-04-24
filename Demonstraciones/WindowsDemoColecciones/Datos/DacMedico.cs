using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDemoColecciones.Models;
namespace WindowsDemoColecciones.Datos
{
    public static class DacMedico
    {
        /// <summary>
        /// Modelo conectado. En linea con la tabla
        /// Medico de la base de datos DBClinica
        /// </summary>
        /// <returns>
        /// Retorna una lista de medicos.
        /// </returns>
        public static List<Medico> Listar()
        {
            // TODO falta implementar el codigo
            // En la DB Select.... from Medico
            return null;
        }

        /// <summary>
        /// Modelo desconectado. Filtra la tabla Medico por Especialidad
        /// </summary>
        /// <param name="especialidad">
        /// espera una cadena con el valor de la especialidad
        /// </param>
        /// <returns>
        /// devuelve una lista de Medicos
        /// </returns>
        public static List<Medico> Listar(string especialidad)
        {
            //TODO falta implementar el codigo
            // En la DB Select .... from Medico where Especialidad = ...
            return null;
        }

        public static List<Medico> Listar(string especialidad, string ciudad)
        {
            //TODO falta implementar el codigo
            // En la DB Select... from Medico where
            // Especialidad = ... AND Ciudad= ...
            return null;
        }
    }
}
