﻿
namespace PresentacionWindows
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnFiltrarporEstado = new System.Windows.Forms.Button();
            this.gridState = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridState)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro por estado";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(302, 130);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 1;
            // 
            // btnFiltrarporEstado
            // 
            this.btnFiltrarporEstado.Location = new System.Drawing.Point(479, 128);
            this.btnFiltrarporEstado.Name = "btnFiltrarporEstado";
            this.btnFiltrarporEstado.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarporEstado.TabIndex = 2;
            this.btnFiltrarporEstado.Text = "Filtrar";
            this.btnFiltrarporEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarporEstado.Click += new System.EventHandler(this.btnFiltrarporEstado_Click);
            // 
            // gridState
            // 
            this.gridState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridState.Location = new System.Drawing.Point(286, 190);
            this.gridState.Name = "gridState";
            this.gridState.Size = new System.Drawing.Size(240, 150);
            this.gridState.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(186, 49);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(324, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(462, 49);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.gridState);
            this.Controls.Add(this.btnFiltrarporEstado);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnFiltrarporEstado;
        private System.Windows.Forms.DataGridView gridState;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

