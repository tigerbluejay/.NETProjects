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
    }
}
