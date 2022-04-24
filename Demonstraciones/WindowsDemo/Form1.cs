using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="Juan" && txtPassword.Text=="1234")
            {
                MessageBox.Show("Bienvenido al sistema " + txtNombre.Text);
            } else
            {
                MessageBox.Show("No esta ingresado en el sistema " + txtNombre.Text);
            }
        }
    }
}
