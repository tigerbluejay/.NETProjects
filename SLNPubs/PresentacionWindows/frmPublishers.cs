using Datos.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class frmPublishers : Form
    {
        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            MostrarPublishers();
            MostrarPaisCombo();
        }

        private void MostrarPaisCombo()
        {
            DataTable dt = DacPublisher.TraerPaises();
            cmbPublishers.DataSource = dt;
            cmbPublishers.DisplayMember = dt.Columns["country"].ToString();
            cmbPublishers.ValueMember = dt.Columns["country"].ToString();
        }

        private void MostrarPublishers()
        {
            DataSet ds = DacPublisher.ListarDs();
            gridPublishers.DataSource = ds.Tables["publishers"];
        }

        private void cmbPublishers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string pais = cmbPublishers.SelectedValue.ToString();
            DataTable dt = DacPublisher.ListarDt(pais);
            gridPublishers.DataSource = dt;
        }
    }
}
