using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoStatic.Entidades;
using WindowsDemoStatic.EntidadesEstaticas;
namespace WindowsDemoStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("A");
            Cliente cliente2 = new Cliente("B");
            MessageBox.Show(Cliente.Instancias.ToString());

            Cliente cliente3 = new Cliente("D");
            Cliente cliente4 = new Cliente("G");

            MessageBox.Show(Cliente.Instancias.ToString());
        }

        private void btnPruebaCalculadora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Calculadora.Sumar(10, 25)));
        }

        private void btnComisionVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor("Gomez", "Juan", 121);
            Vendedor vendedor2 = new Vendedor("Perez", "Irma", 122);

            MessageBox.Show(Convert.ToString(Vendedor.Comision));
            Vendedor.Comision = 15;

            Vendedor vendedor3 = new Vendedor("Suarez", "Mirta", 323);
            MessageBox.Show(Convert.ToString(Vendedor.Comision));

        }
    }
}
