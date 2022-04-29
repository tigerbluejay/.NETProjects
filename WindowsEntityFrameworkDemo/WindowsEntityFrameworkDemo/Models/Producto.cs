using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WindowsEntityFrameworkDemo.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }
        [Required] // no acepta nulos
        [Column(TypeName ="VarChar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column(TypeName ="Money")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
    }
}
