using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cbCiudad.Items.Add("La Plata");
                cbCiudad.Items.Add("Bariloche");
                cbCiudad.Items.Add("Rosario");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string cadena = txtNombre.Text + ", " + txtEdad.Text + " " + txtEmail.Text + " " + cbCiudad.SelectedItem.Text;
            lblMensaje.Text = cadena;

        }

        protected void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = cbCiudad.SelectedItem.Text;
        }
    }
}