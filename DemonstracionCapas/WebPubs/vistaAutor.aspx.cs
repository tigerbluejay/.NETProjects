using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatosEF.AdminDatos;
using DatosEF.Data;

namespace WebPubs
{
    public partial class vistaAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void MostrarTodos()
        {
            gridAuthor.DataSource = DacAuthor.Listar();
            gridAuthor.DataBind();
        }

        protected void btnLintarCity_Click(object sender, EventArgs e)
        {
            gridAuthor.DataSource = DacAuthor.Listar("Oakland");
            gridAuthor.DataBind();
        }

        protected void btnTraerUno_Click(object sender, EventArgs e)
        {
            author author = DacAuthor.TraerUno("172-32-1176");
            lblMensaje.Text = author.au_fname + "," + author.au_lname;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            author author = new author() { au_id = "172-32-8888", 
                au_lname = "Juan", au_fname = "Perez", phone = "123-1211", 
                address = "Calle 10", city = "La Plata", state = "BS", 
                zip = "94025", contract = true };

            int filasAfectadas = DacAuthor.Insertar(author);

            if (filasAfectadas > 0)
            {
                MostrarTodos();
            }

        }

    }
}
