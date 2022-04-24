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
        }

        private void MostrarShippers()
        {
            gridShipper.DataSource = DacShipper.Listar();
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
    }
}
