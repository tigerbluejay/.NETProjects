using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoPropiedades.Models;

namespace WindowsDemoPropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Apellido = "Pint";
            paciente.NroHistoriaClinica = 22222;

            MessageBox.Show(paciente.Apellido + " " + paciente.NroHistoriaClinica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Nombre = "Juan";
            medico.Apellido = "Perez";
            medico.FechaNacimiento = new DateTime(2000, 4, 11);
            medico.Matricula = 1245;

            Medico medico2 = new Medico("Juan", "Lopez", new DateTime(2000, 4, 11), 222);

            MessageBox.Show(medico.Apellido + " " + medico.Matricula.ToString());
            MessageBox.Show(medico2.Apellido + " " + medico2.FechaNacimiento);
        }

        private void btnCrearHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion();

            habitacion.Codigo = 100;
            habitacion.Estado = "Ocupada";

            MessageBox.Show(habitacion.Codigo + " " + habitacion.Estado);
        }
    }
}
