
namespace WindowsProductos
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
            this.btnComputadora = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnInstrumentos = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComputadora
            // 
            this.btnComputadora.Location = new System.Drawing.Point(257, 57);
            this.btnComputadora.Name = "btnComputadora";
            this.btnComputadora.Size = new System.Drawing.Size(211, 23);
            this.btnComputadora.TabIndex = 0;
            this.btnComputadora.Text = "Mostrar Computadoras";
            this.btnComputadora.UseVisualStyleBackColor = true;
            this.btnComputadora.Click += new System.EventHandler(this.btnComputadora_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Location = new System.Drawing.Point(257, 120);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(222, 23);
            this.btnHerramientas.TabIndex = 1;
            this.btnHerramientas.Text = "Mostrar Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnInstrumentos
            // 
            this.btnInstrumentos.Location = new System.Drawing.Point(279, 183);
            this.btnInstrumentos.Name = "btnInstrumentos";
            this.btnInstrumentos.Size = new System.Drawing.Size(173, 23);
            this.btnInstrumentos.TabIndex = 2;
            this.btnInstrumentos.Text = "Mostrar Instrumentos";
            this.btnInstrumentos.UseVisualStyleBackColor = true;
            this.btnInstrumentos.Click += new System.EventHandler(this.btnInstrumentos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(318, 244);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(112, 23);
            this.btnLibros.TabIndex = 3;
            this.btnLibros.Text = "Mostrar Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnInstrumentos);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnComputadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComputadora;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnInstrumentos;
        private System.Windows.Forms.Button btnLibros;
    }
}

