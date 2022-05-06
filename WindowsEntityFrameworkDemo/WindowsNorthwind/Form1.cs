using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsNorthwind.Data;

namespace WindowsNorthwind
{
    public partial class Form1 : Form
    {
        // Crear una instancia de Entity Framework
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarShipper_Click(object sender, EventArgs e)
        {
            
            Shipper shipper = new Shipper()
            {
                ShipperID = 4,
                CompanyName = "DHL",
                Phone = "(503)555-8919"
            };

           
            context.Shippers.Add(shipper);

            // Enviamos la modificacion a la base de datos
            // Se conecta a la base, ejecuta operacion DML y
            // retorna filas afectadas y se desconecta.
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert OK");
                MostrarShippers();
            }
        }

        private void btnModificarShipper_Click(object sender, EventArgs e)
        {
            int shipperid = 4;
            Shipper shipper = context.Shippers.Find(shipperid);

            shipper.CompanyName = "Fed Ex";
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modify OK");
                MostrarShippers();
            }
        }

        private void btnEliminarShipper_Click(object sender, EventArgs e)
        {
            
            int shipperid = 4;
            Shipper shipper = context.Shippers.Find(shipperid);
            context.Shippers.Remove(shipper);
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete OK");
                MostrarShippers();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarShippers();
        }
        private void MostrarShippers()
        {
            // conecta a la db, hace un select
            // retorna una lista de stores y se desconecta
            // a esto se le llama materializar datos, proyectar datos
            List<Shipper> shippers = context.Shippers.ToList();

            gridShippers.DataSource = shippers;
        }
    }
}
