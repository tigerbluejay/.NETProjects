using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEntityFrameworkDemo.Models
{
    [Table("Factura")]
    public class Factura
    {
        public int Id { get; set; }
        
        [Required] // no acepta nulos
        public DateTime FechaFactura { get; set; }
        public Cliente Cliente { get; set; }

        public List<FacturaDetalle> FacturaDetalles { get; set; }
    }
}
