using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEntityFrameworkDBFirst.Data;

namespace WindowsEntityFrameworkDBFirst
{
    public partial class frmLinq : Form
    {
        // Crear instancia de Entity Framework (del dbContext)
        PubsContext context = new PubsContext();
        public frmLinq()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            // Traer Todos

            var authors = (from a in context.Authors
                           select a).ToList();

            // Enlace de datos
            gridAutores.DataSource = authors;
        }

        private void btnTraerporId_Click(object sender, EventArgs e)
        {
            Author author = (from a in context.Authors
                             where a.au_id == "341-22-1782"
                             select a).SingleOrDefault();
            MessageBox.Show(author.au_lname + " " + author.au_fname);
        }

        private void btnTraerporCiudad_Click(object sender, EventArgs e)
        {
            List<Author> author = (from a in context.Authors
                                   where a.city == "Oakland"
                                   select a).ToList();
            gridAutores.DataSource = author;
        }

        private void brnTraerPublicadoresyLibros_Click(object sender, EventArgs e)
        {
            var publisherTitles = (from p in context.Publishers
                                   join
                                   t in context.Titles
                                   on p.pub_id equals t.pub_id
                                   select new { 
                                   Editor = p.pub_name, Titulo = t.title1
                                   }).ToList();

            gridAutores.DataSource = publisherTitles;
        }

        private void brnTraerAutores_Click(object sender, EventArgs e)
        {
            var authors = from a in context.Authors
                          select a;

            foreach (var item in authors)
            {
                lstAutores.Items.Add(item.au_fname + ", " + item.au_lname);
            }
        }
    }
}
