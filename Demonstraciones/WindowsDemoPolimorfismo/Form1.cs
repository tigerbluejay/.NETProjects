using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoPolimorfismo.EntidadesEscuela;
using WindowsDemoPolimorfismo.EntidadesAjedrez;
using WindowsDemoPolimorfismo.EntidadesAnimales;

namespace WindowsDemoPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancia_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                Apellido = "Perez",
                Nombre = "Juan",
                FechaNacimiento = new DateTime(2000, 11, 5),
                Matricula = 555
            };
            MessageBox.Show(alumno.Imprimir());
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();
            MessageBox.Show(peon.Mover());
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover());
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show(torre.Mover());
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(3, 1, 40, true);
            MessageBox.Show(leon.Imprimir());
            MessageBox.Show(leon.ImprimirComida());
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(2,1,5,false);
            MessageBox.Show(conejo.Imprimir());
            MessageBox.Show(conejo.ImprimirComida());
        }

        private void btnLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(4, 1, 3, true);
            MessageBox.Show(loro.Imprimir());
            MessageBox.Show(loro.ImprimirComida());
        }
    }
}
