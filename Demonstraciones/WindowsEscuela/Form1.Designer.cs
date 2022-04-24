
namespace WindowsEscuela
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
            this.btnMostrarAlumno = new System.Windows.Forms.Button();
            this.btnMostrarProfesor = new System.Windows.Forms.Button();
            this.btnMostrarEstablecimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarAlumno
            // 
            this.btnMostrarAlumno.Location = new System.Drawing.Point(353, 126);
            this.btnMostrarAlumno.Name = "btnMostrarAlumno";
            this.btnMostrarAlumno.Size = new System.Drawing.Size(126, 23);
            this.btnMostrarAlumno.TabIndex = 0;
            this.btnMostrarAlumno.Text = "Mostrar Alumno";
            this.btnMostrarAlumno.UseVisualStyleBackColor = true;
            this.btnMostrarAlumno.Click += new System.EventHandler(this.btnMostrarAlumno_Click);
            // 
            // btnMostrarProfesor
            // 
            this.btnMostrarProfesor.Location = new System.Drawing.Point(353, 186);
            this.btnMostrarProfesor.Name = "btnMostrarProfesor";
            this.btnMostrarProfesor.Size = new System.Drawing.Size(126, 23);
            this.btnMostrarProfesor.TabIndex = 1;
            this.btnMostrarProfesor.Text = "Mostrar Profesor";
            this.btnMostrarProfesor.UseVisualStyleBackColor = true;
            this.btnMostrarProfesor.Click += new System.EventHandler(this.btnMostrarProfesor_Click);
            // 
            // btnMostrarEstablecimiento
            // 
            this.btnMostrarEstablecimiento.Location = new System.Drawing.Point(314, 249);
            this.btnMostrarEstablecimiento.Name = "btnMostrarEstablecimiento";
            this.btnMostrarEstablecimiento.Size = new System.Drawing.Size(204, 23);
            this.btnMostrarEstablecimiento.TabIndex = 2;
            this.btnMostrarEstablecimiento.Text = "Mostrar Establecimiento";
            this.btnMostrarEstablecimiento.UseVisualStyleBackColor = true;
            this.btnMostrarEstablecimiento.Click += new System.EventHandler(this.btnMostrarEstablecimiento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarEstablecimiento);
            this.Controls.Add(this.btnMostrarProfesor);
            this.Controls.Add(this.btnMostrarAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarAlumno;
        private System.Windows.Forms.Button btnMostrarProfesor;
        private System.Windows.Forms.Button btnMostrarEstablecimiento;
    }
}

