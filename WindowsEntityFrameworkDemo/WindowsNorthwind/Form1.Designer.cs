
namespace WindowsNorthwind
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
            this.btnInsertarShipper = new System.Windows.Forms.Button();
            this.btnModificarShipper = new System.Windows.Forms.Button();
            this.btnEliminarShipper = new System.Windows.Forms.Button();
            this.gridShippers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarShipper
            // 
            this.btnInsertarShipper.Location = new System.Drawing.Point(75, 68);
            this.btnInsertarShipper.Name = "btnInsertarShipper";
            this.btnInsertarShipper.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarShipper.TabIndex = 0;
            this.btnInsertarShipper.Text = "Insertar Shipper";
            this.btnInsertarShipper.UseVisualStyleBackColor = true;
            this.btnInsertarShipper.Click += new System.EventHandler(this.btnInsertarShipper_Click);
            // 
            // btnModificarShipper
            // 
            this.btnModificarShipper.Location = new System.Drawing.Point(240, 68);
            this.btnModificarShipper.Name = "btnModificarShipper";
            this.btnModificarShipper.Size = new System.Drawing.Size(75, 23);
            this.btnModificarShipper.TabIndex = 1;
            this.btnModificarShipper.Text = "ModificarShipper";
            this.btnModificarShipper.UseVisualStyleBackColor = true;
            this.btnModificarShipper.Click += new System.EventHandler(this.btnModificarShipper_Click);
            // 
            // btnEliminarShipper
            // 
            this.btnEliminarShipper.Location = new System.Drawing.Point(392, 68);
            this.btnEliminarShipper.Name = "btnEliminarShipper";
            this.btnEliminarShipper.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarShipper.TabIndex = 2;
            this.btnEliminarShipper.Text = "Eliminar Shipper";
            this.btnEliminarShipper.UseVisualStyleBackColor = true;
            this.btnEliminarShipper.Click += new System.EventHandler(this.btnEliminarShipper_Click);
            // 
            // gridShippers
            // 
            this.gridShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShippers.Location = new System.Drawing.Point(75, 152);
            this.gridShippers.Name = "gridShippers";
            this.gridShippers.Size = new System.Drawing.Size(398, 214);
            this.gridShippers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridShippers);
            this.Controls.Add(this.btnEliminarShipper);
            this.Controls.Add(this.btnModificarShipper);
            this.Controls.Add(this.btnInsertarShipper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridShippers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarShipper;
        private System.Windows.Forms.Button btnModificarShipper;
        private System.Windows.Forms.Button btnEliminarShipper;
        private System.Windows.Forms.DataGridView gridShippers;
    }
}

