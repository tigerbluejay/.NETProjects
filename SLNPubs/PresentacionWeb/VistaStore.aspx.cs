using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Consultas;

namespace PresentacionWeb
{
    public partial class VistaStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridState.DataSource = DacStore.Listar();
            GridState.DataBind();
        }

        protected void GridView1_Load(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string state = txtState.Text;
            GridState.DataSource = DacStore.Listar(state);
            GridState.DataBind();
        }
    }
}