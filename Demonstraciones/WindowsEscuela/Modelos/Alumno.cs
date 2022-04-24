using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEscuela.Modelos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int NroMatricula { get; set; }

        public Alumno(string Nombre, string Apellido, DateTime FechaNacimiento,
            string Direccion, string Email, int Telefono, int NroMatricula)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaNacimiento = FechaNacimiento;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.NroMatricula = NroMatricula;
        }    
    }
}
