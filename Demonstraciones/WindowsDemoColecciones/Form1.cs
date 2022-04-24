using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoColecciones.Models;

namespace WindowsDemoColecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearyMostrarListaMedicos_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = Carga();

            Mostrar(medicos);
            Mostrar(medicos, 444);
        }

        private void Mostrar(List<Medico> medicos)
        {
            gridMedicos.DataSource = medicos;
        }

        private static List<Medico> Carga()
        {
            List<Medico> medicos = new List<Medico>();

            Medico medico1 = new Medico() { Apellido = "Pink", Nombre = "Celeste", Matricula = 444 };
            medicos.Add(medico1);
            medicos.Add(new Medico() { Apellido = "Fernandez", Nombre = "Mariano", Matricula = 445 });
            return medicos;
        }

        private void Mostrar(List<Medico> medicos, int matricula)
        {
            foreach (var item in medicos)
            {
                if (item.Matricula == matricula)
                {
                    MessageBox.Show(item.Apellido + " " + item.Nombre);
                }
            }
        }

        private void btnCrearyMostrarProfesores_Click(object sender, EventArgs e)
        {
            List<Profesor> profesores = CargarProfesores();
            MostrarProfesores(profesores);
            MostrarProfesores(profesores, "Cs Politicas");

        }

        private static List<Profesor> CargarProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();

            Profesor profesor1 = new Profesor() { Apellido = "Lindau", Nombre = "Juan", Especialidad = "Cs Politicas" };
            Profesor profesor2 = new Profesor() { Apellido = "Cook", Nombre = "Curtis", Especialidad = "Cs Politicas" };
            Profesor profesor3 = new Profesor() { Apellido = "Hecox", Nombre = "Walt", Especialidad = "Economia" };

            profesores.Add(profesor1);
            profesores.Add(profesor2);
            profesores.Add(profesor3);
            return profesores;
        }

        private void MostrarProfesores(List<Profesor> profesores)
        {
            gridProfesores.DataSource = profesores;
        }

        private void MostrarProfesores(List<Profesor> profesores, string especialidad)
        {
            foreach (var item in profesores)
            {
                if (item.Especialidad == especialidad)
                {
                    MessageBox.Show(item.Apellido + " " + item.Nombre);
                }
            }
        }
    }
}
