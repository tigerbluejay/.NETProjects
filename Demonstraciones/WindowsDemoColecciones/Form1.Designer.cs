
namespace WindowsDemoColecciones
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
            this.btnCrearyMostrarListaMedicos = new System.Windows.Forms.Button();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnCrearyMostrarProfesores = new System.Windows.Forms.Button();
            this.gridProfesores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearyMostrarListaMedicos
            // 
            this.btnCrearyMostrarListaMedicos.Location = new System.Drawing.Point(145, 87);
            this.btnCrearyMostrarListaMedicos.Name = "btnCrearyMostrarListaMedicos";
            this.btnCrearyMostrarListaMedicos.Size = new System.Drawing.Size(240, 23);
            this.btnCrearyMostrarListaMedicos.TabIndex = 0;
            this.btnCrearyMostrarListaMedicos.Text = "Crear y Mostrar Lista de Medicos";
            this.btnCrearyMostrarListaMedicos.UseVisualStyleBackColor = true;
            this.btnCrearyMostrarListaMedicos.Click += new System.EventHandler(this.btnCrearyMostrarListaMedicos_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(145, 163);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(240, 150);
            this.gridMedicos.TabIndex = 1;
            // 
            // btnCrearyMostrarProfesores
            // 
            this.btnCrearyMostrarProfesores.Location = new System.Drawing.Point(494, 87);
            this.btnCrearyMostrarProfesores.Name = "btnCrearyMostrarProfesores";
            this.btnCrearyMostrarProfesores.Size = new System.Drawing.Size(240, 23);
            this.btnCrearyMostrarProfesores.TabIndex = 2;
            this.btnCrearyMostrarProfesores.Text = "Crear y Mostrar Profesores";
            this.btnCrearyMostrarProfesores.UseVisualStyleBackColor = true;
            this.btnCrearyMostrarProfesores.Click += new System.EventHandler(this.btnCrearyMostrarProfesores_Click);
            // 
            // gridProfesores
            // 
            this.gridProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfesores.Location = new System.Drawing.Point(494, 163);
            this.gridProfesores.Name = "gridProfesores";
            this.gridProfesores.Size = new System.Drawing.Size(240, 150);
            this.gridProfesores.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridProfesores);
            this.Controls.Add(this.btnCrearyMostrarProfesores);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnCrearyMostrarListaMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearyMostrarListaMedicos;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnCrearyMostrarProfesores;
        private System.Windows.Forms.DataGridView gridProfesores;
    }
}

