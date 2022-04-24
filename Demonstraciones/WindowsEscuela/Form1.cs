using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEscuela.Modelos;

namespace WindowsEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno("Jose", "Iriarte", new DateTime(1981, 3, 12),
            "Guise 1784", "jose@gmail.com", 719389, 1111);

            MessageBox.Show(alumno1.Apellido + " " + alumno1.Nombre);
            
        }

        private void btnMostrarProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor("Juan", "Lindau", "184 Oak St.",
                "juan@gmail.com", 683838, "PhD");

            MessageBox.Show(profesor1.Apellido + " " + profesor1.Titulo);
            }

        private void btnMostrarEstablecimiento_Click(object sender, EventArgs e)
        {
            Establecimiento establecimiento1 = new Establecimiento("Colorado College",
               "174 Iab St.", "establecimiento@gmail.com", 719834, "www.cc.edu");
            MessageBox.Show(establecimiento1.Nombre);
        }
    }
    
}
