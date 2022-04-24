using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Consultas;
using Datos.Modelos;

namespace PresentacionWeb
{
    public partial class VistaShipper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridShipper.DataSource = DacShipper.Listar();
            gridShipper.DataBind();
        }

        protected void btnShipper_Click(object sender, EventArgs e)
        {
            string id = txtShipperId.Text;
            gridShipper.DataSource = DacShipper.Listar(id);
            gridShipper.DataBind();
        }
    }
}