using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsHerenciaClinica.Entidades;


namespace WindowsHerenciaClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            Director director = new Director("Rodriguez",
                "Juan", 289393, "Cardiologia", 111);
            MessageBox.Show(director.Apellido + " Especialidad" +
                director.Especialidad);
            Enfermero enfermero = new Enfermero("Lopez",
                "Pedro", 273838, 111);
            MessageBox.Show(enfermero.Apellido + " Legajo " +
                enfermero.Legajo);
        }
    }
}
