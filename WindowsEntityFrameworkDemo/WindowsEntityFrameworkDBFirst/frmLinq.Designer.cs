
namespace WindowsEntityFrameworkDBFirst
{
    partial class frmLinq
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
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnTraerporId = new System.Windows.Forms.Button();
            this.btnTraerporCiudad = new System.Windows.Forms.Button();
            this.brnTraerPublicadoresyLibros = new System.Windows.Forms.Button();
            this.brnTraerAutores = new System.Windows.Forms.Button();
            this.lstAutores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutores
            // 
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Location = new System.Drawing.Point(197, 163);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(292, 150);
            this.gridAutores.TabIndex = 0;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(197, 99);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodos.TabIndex = 1;
            this.btnTraerTodos.Text = "Traer Todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnTraerporId
            // 
            this.btnTraerporId.Location = new System.Drawing.Point(292, 98);
            this.btnTraerporId.Name = "btnTraerporId";
            this.btnTraerporId.Size = new System.Drawing.Size(75, 23);
            this.btnTraerporId.TabIndex = 2;
            this.btnTraerporId.Text = "Traer por Id";
            this.btnTraerporId.UseVisualStyleBackColor = true;
            this.btnTraerporId.Click += new System.EventHandler(this.btnTraerporId_Click);
            // 
            // btnTraerporCiudad
            // 
            this.btnTraerporCiudad.Location = new System.Drawing.Point(390, 98);
            this.btnTraerporCiudad.Name = "btnTraerporCiudad";
            this.btnTraerporCiudad.Size = new System.Drawing.Size(99, 23);
            this.btnTraerporCiudad.TabIndex = 3;
            this.btnTraerporCiudad.Text = "Traer por Ciudad";
            this.btnTraerporCiudad.UseVisualStyleBackColor = true;
            this.btnTraerporCiudad.Click += new System.EventHandler(this.btnTraerporCiudad_Click);
            // 
            // brnTraerPublicadoresyLibros
            // 
            this.brnTraerPublicadoresyLibros.Location = new System.Drawing.Point(539, 98);
            this.brnTraerPublicadoresyLibros.Name = "brnTraerPublicadoresyLibros";
            this.brnTraerPublicadoresyLibros.Size = new System.Drawing.Size(80, 60);
            this.brnTraerPublicadoresyLibros.TabIndex = 4;
            this.brnTraerPublicadoresyLibros.Text = "Traer Publicadores y Libros";
            this.brnTraerPublicadoresyLibros.UseVisualStyleBackColor = true;
            this.brnTraerPublicadoresyLibros.Click += new System.EventHandler(this.brnTraerPublicadoresyLibros_Click);
            // 
            // brnTraerAutores
            // 
            this.brnTraerAutores.Location = new System.Drawing.Point(197, 351);
            this.brnTraerAutores.Name = "brnTraerAutores";
            this.brnTraerAutores.Size = new System.Drawing.Size(75, 37);
            this.brnTraerAutores.TabIndex = 5;
            this.brnTraerAutores.Text = "Traer Nombre Autores";
            this.brnTraerAutores.UseVisualStyleBackColor = true;
            this.brnTraerAutores.Click += new System.EventHandler(this.brnTraerAutores_Click);
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(334, 351);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(120, 95);
            this.lstAutores.TabIndex = 6;
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAutores);
            this.Controls.Add(this.brnTraerAutores);
            this.Controls.Add(this.brnTraerPublicadoresyLibros);
            this.Controls.Add(this.btnTraerporCiudad);
            this.Controls.Add(this.btnTraerporId);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridAutores);
            this.Name = "frmLinq";
            this.Text = "frmLinq";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnTraerporId;
        private System.Windows.Forms.Button btnTraerporCiudad;
        private System.Windows.Forms.Button brnTraerPublicadoresyLibros;
        private System.Windows.Forms.Button brnTraerAutores;
        private System.Windows.Forms.ListBox lstAutores;
    }
}