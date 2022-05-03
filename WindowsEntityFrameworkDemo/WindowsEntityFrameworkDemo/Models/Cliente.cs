using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEntityFrameworkDemo.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set;}
        [Required] // no acepta nulos
        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        public DateTime FechadeNacimiento { get; set; }

        public List<Factura> Facturas { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
    }
}
