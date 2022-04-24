using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProductos.Models;

namespace WindowsProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Computadora computadora1 = new Computadora("MSI", 1999, "Almagro",
                "Gamer");
            Computadora computadora2 = new Computadora("Dell", 600, "Online",
                "Estudio");
            MessageBox.Show(computadora1.Nombre + " " + computadora2.Nombre);
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramienta1 = new Herramientas("Serrucho",
                1, false, 1000);
            Herramientas cajaTornillos = new Herramientas("Caja de Tornillos",
                10, false, 2000);
            MessageBox.Show(herramienta1.Nombre + " " + cajaTornillos.Nombre);
           
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            Instrumentos trompeta = new Instrumentos(false, true, false, "Trompeta");
            Instrumentos arpa = new Instrumentos(false, false, true, "Arpa");
            MessageBox.Show(trompeta.Nombre + " " + arpa.Nombre);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Libros Planetfall = new Libros("Planetfall", "Planeta", 2019, false);
            Libros MartianChronicles = new Libros("The Martian Chronicles", "Planeta",
                2009, true);
            MessageBox.Show(Planetfall.Nombre + " " + MartianChronicles.Nombre);
        }
    }
}
