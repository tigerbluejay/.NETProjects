using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPropiedades.Models
{
    public class Paciente
    {
        #region propiedades autoimplementadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }
        #endregion
    }
}
