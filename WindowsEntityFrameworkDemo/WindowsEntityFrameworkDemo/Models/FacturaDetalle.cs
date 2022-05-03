using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WindowsEntityFrameworkDemo.Models
{
    public class FacturaDetalle
    {
        [Key]
        public int IdFacturaDetalle { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
