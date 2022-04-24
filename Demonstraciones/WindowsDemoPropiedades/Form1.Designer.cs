
namespace WindowsDemoPropiedades
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnCrearHabitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(362, 127);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(153, 23);
            this.btnCrearMedico.TabIndex = 0;
            this.btnCrearMedico.Text = "Crear Instancia de Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(362, 181);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(166, 23);
            this.btnCrearPaciente.TabIndex = 1;
            this.btnCrearPaciente.Text = "Crear Instancia de Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnCrearHabitacion
            // 
            this.btnCrearHabitacion.Location = new System.Drawing.Point(362, 238);
            this.btnCrearHabitacion.Name = "btnCrearHabitacion";
            this.btnCrearHabitacion.Size = new System.Drawing.Size(193, 23);
            this.btnCrearHabitacion.TabIndex = 2;
            this.btnCrearHabitacion.Text = "Crear Instancia de Habitacion";
            this.btnCrearHabitacion.UseVisualStyleBackColor = true;
            this.btnCrearHabitacion.Click += new System.EventHandler(this.btnCrearHabitacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearHabitacion);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.btnCrearMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnCrearHabitacion;
    }
}

