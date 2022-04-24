using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEscuela.Modelos
{
    public class Establecimiento
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string SitioWeb { get; set; }

        public Establecimiento(string Nombre, string Direccion, string Email,
            int Telefono, string SitioWeb)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.SitioWeb = SitioWeb;
        }
    }
}
