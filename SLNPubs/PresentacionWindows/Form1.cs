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
using Datos.Models;

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
            MostrarTiendas();
        }

        private void MostrarTiendas()
        {
            gridState.DataSource = DacStore.Listar();
        }

        private void btnFiltrarporEstado_Click(object sender, EventArgs e)
        {
            string state = txtState.Text;

            if (state == "Todas")
            {
                MostrarTiendas();
            }
            else
            {
                gridState.DataSource = DacStore.Listar(state);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { StoreId = "5001", StoreName = "A", StoreAddress = "Calle 7", City = "La Plata", State = "BS", Zip = "12345" };

            int filasAfectadas = DacStore.Insertar(store);

            if (filasAfectadas > 0)
            {
                MostrarTiendas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { StoreId = "5001", StoreName = "AAA", StoreAddress = "Calle 7", City = "La Plata", State = "BS", Zip = "11111" };

            int filasAfectadas = DacStore.Modificar(store);

            if (filasAfectadas > 0)
            {
                MostrarTiendas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = "5001";
            int filasAfectadas = DacStore.Eliminar(id);
            if (filasAfectadas > 0)
            {
                MostrarTiendas();
            }
        }
    }
}
