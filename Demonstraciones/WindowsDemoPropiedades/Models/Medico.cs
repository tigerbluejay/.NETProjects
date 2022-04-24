using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPropiedades.Models
{
    public class Medico
    {
        #region constructores
        public Medico() { }

        public Medico(int matricula)
        {
            Matricula = matricula;
        }
        public Medico(string Nombre, string Apellido, int matricula)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            Matricula = matricula;
        }
        public Medico(string Nombre, string Apellido, DateTime fechaNacimiento, int matricula)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            FechaNacimiento = fechaNacimiento;
            Matricula = matricula;
        }
        #endregion


        #region propiedades autoimplementadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Matricula { get; set; }
        #endregion

      
    }
}