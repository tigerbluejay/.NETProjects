using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoHerencia.Entidades;
using WindowsDemoHerencia.EntidadesBase;
namespace WindowsDemoHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancia_Click(object sender, EventArgs e)
        {
            Profesor persona = new Profesor("Pint", "Celina", new DateTime(2000, 11, 4),"PhD");
            MessageBox.Show(persona.Apellido + " " + persona.Nombre);

            Alumno alumno = new Alumno("Fernandez", "Javier", new DateTime(2005, 8, 4), 4444);
            MessageBox.Show(alumno.Apellido + ", " + alumno.Nombre + " Matricula " + alumno.Matricula);
        }
    }
}
