using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Consultas;
using Datos.Modelos;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarShippers();
            MostrarRegions();
        }

        private void MostrarShippers()
        {
            gridShipper.DataSource = DacShipper.Listar();
        }

        private void MostrarRegions()
        {
            gridRegion.DataSource = DacRegion.Listar();
        }

        private void btnTraerShipperporId_Click(object sender, EventArgs e)
        {
            string id = txtShipperId.Text;

            if (id == "Todos")
            {
                MostrarShippers();
            }
            else
            {
                gridShipper.DataSource = DacShipper.Listar(id);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos.Modelos.Region region = new Datos.Modelos.Region() { RegionId = 283, RegionDescription = "Tundra" };

            int filasAfectadas = DacRegion.Insertar(region);

            if (filasAfectadas > 0)
            {
                MostrarRegions();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Datos.Modelos.Region region = new Datos.Modelos.Region() { RegionId = 283, RegionDescription = "Deep Tundra" };

            int filasAfectadas = DacRegion.Modificar(region);

            if (filasAfectadas > 0)
            {
                MostrarRegions();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = 283;
            int filasAfectadas = DacRegion.Eliminar(id);
            if (filasAfectadas > 0)
            {
                MostrarRegions();
            }
        }
    }
}
