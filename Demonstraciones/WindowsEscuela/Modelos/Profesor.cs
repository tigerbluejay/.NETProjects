using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEscuela.Modelos
{
    public class Profesor
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Titulo { get; set; }

        public Profesor(string Nombre, string Apellido, string Direccion,
            string Email, int Telefono, string Titulo)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Titulo = Titulo;

        }
    }
}
