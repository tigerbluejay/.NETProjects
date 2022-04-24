
namespace WindowsDemoPolimorfismo
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
            this.btnCrearInstancia = new System.Windows.Forms.Button();
            this.btnMoverPeon = new System.Windows.Forms.Button();
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.btnLeon = new System.Windows.Forms.Button();
            this.btnConejo = new System.Windows.Forms.Button();
            this.btnLoro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstancia
            // 
            this.btnCrearInstancia.Location = new System.Drawing.Point(220, 150);
            this.btnCrearInstancia.Name = "btnCrearInstancia";
            this.btnCrearInstancia.Size = new System.Drawing.Size(122, 23);
            this.btnCrearInstancia.TabIndex = 0;
            this.btnCrearInstancia.Text = "Crear Instancia";
            this.btnCrearInstancia.UseVisualStyleBackColor = true;
            this.btnCrearInstancia.Click += new System.EventHandler(this.btnCrearInstancia_Click);
            // 
            // btnMoverPeon
            // 
            this.btnMoverPeon.Location = new System.Drawing.Point(127, 241);
            this.btnMoverPeon.Name = "btnMoverPeon";
            this.btnMoverPeon.Size = new System.Drawing.Size(75, 23);
            this.btnMoverPeon.TabIndex = 1;
            this.btnMoverPeon.Text = "Mover Peon";
            this.btnMoverPeon.UseVisualStyleBackColor = true;
            this.btnMoverPeon.Click += new System.EventHandler(this.btnMoverPeon_Click);
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(237, 241);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(94, 23);
            this.btnMoverCaballo.TabIndex = 2;
            this.btnMoverCaballo.Text = "Mover Caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(376, 241);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(75, 23);
            this.btnMoverTorre.TabIndex = 3;
            this.btnMoverTorre.Text = "Mover Torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // btnLeon
            // 
            this.btnLeon.Location = new System.Drawing.Point(127, 320);
            this.btnLeon.Name = "btnLeon";
            this.btnLeon.Size = new System.Drawing.Size(75, 23);
            this.btnLeon.TabIndex = 4;
            this.btnLeon.Text = "Leon";
            this.btnLeon.UseVisualStyleBackColor = true;
            this.btnLeon.Click += new System.EventHandler(this.btnLeon_Click);
            // 
            // btnConejo
            // 
            this.btnConejo.Location = new System.Drawing.Point(256, 320);
            this.btnConejo.Name = "btnConejo";
            this.btnConejo.Size = new System.Drawing.Size(75, 23);
            this.btnConejo.TabIndex = 5;
            this.btnConejo.Text = "Conejo";
            this.btnConejo.UseVisualStyleBackColor = true;
            this.btnConejo.Click += new System.EventHandler(this.btnConejo_Click);
            // 
            // btnLoro
            // 
            this.btnLoro.Location = new System.Drawing.Point(376, 319);
            this.btnLoro.Name = "btnLoro";
            this.btnLoro.Size = new System.Drawing.Size(75, 23);
            this.btnLoro.TabIndex = 6;
            this.btnLoro.Text = "Loro";
            this.btnLoro.UseVisualStyleBackColor = true;
            this.btnLoro.Click += new System.EventHandler(this.btnLoro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoro);
            this.Controls.Add(this.btnConejo);
            this.Controls.Add(this.btnLeon);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.btnMoverCaballo);
            this.Controls.Add(this.btnMoverPeon);
            this.Controls.Add(this.btnCrearInstancia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstancia;
        private System.Windows.Forms.Button btnMoverPeon;
        private System.Windows.Forms.Button btnMoverCaballo;
        private System.Windows.Forms.Button btnMoverTorre;
        private System.Windows.Forms.Button btnLeon;
        private System.Windows.Forms.Button btnConejo;
        private System.Windows.Forms.Button btnLoro;
    }
}

