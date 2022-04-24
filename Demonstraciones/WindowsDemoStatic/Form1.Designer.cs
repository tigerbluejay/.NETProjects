
namespace WindowsDemoStatic
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
            this.btnCrearClientes = new System.Windows.Forms.Button();
            this.btnPruebaCalculadora = new System.Windows.Forms.Button();
            this.btnComisionVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearClientes
            // 
            this.btnCrearClientes.Location = new System.Drawing.Point(222, 159);
            this.btnCrearClientes.Name = "btnCrearClientes";
            this.btnCrearClientes.Size = new System.Drawing.Size(105, 23);
            this.btnCrearClientes.TabIndex = 0;
            this.btnCrearClientes.Text = "Crear Clientes";
            this.btnCrearClientes.UseVisualStyleBackColor = true;
            this.btnCrearClientes.Click += new System.EventHandler(this.btnCrearClientes_Click);
            // 
            // btnPruebaCalculadora
            // 
            this.btnPruebaCalculadora.Location = new System.Drawing.Point(212, 233);
            this.btnPruebaCalculadora.Name = "btnPruebaCalculadora";
            this.btnPruebaCalculadora.Size = new System.Drawing.Size(125, 23);
            this.btnPruebaCalculadora.TabIndex = 1;
            this.btnPruebaCalculadora.Text = "Prueba Calculadora";
            this.btnPruebaCalculadora.UseVisualStyleBackColor = true;
            this.btnPruebaCalculadora.Click += new System.EventHandler(this.btnPruebaCalculadora_Click);
            // 
            // btnComisionVendedor
            // 
            this.btnComisionVendedor.Location = new System.Drawing.Point(240, 310);
            this.btnComisionVendedor.Name = "btnComisionVendedor";
            this.btnComisionVendedor.Size = new System.Drawing.Size(73, 23);
            this.btnComisionVendedor.TabIndex = 2;
            this.btnComisionVendedor.Text = "Comision Vendedor";
            this.btnComisionVendedor.UseVisualStyleBackColor = true;
            this.btnComisionVendedor.Click += new System.EventHandler(this.btnComisionVendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComisionVendedor);
            this.Controls.Add(this.btnPruebaCalculadora);
            this.Controls.Add(this.btnCrearClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearClientes;
        private System.Windows.Forms.Button btnPruebaCalculadora;
        private System.Windows.Forms.Button btnComisionVendedor;
    }
}

