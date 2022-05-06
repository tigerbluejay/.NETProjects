
namespace WindowsEntityFrameworkDBFirst
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
            this.btnInsertarStore = new System.Windows.Forms.Button();
            this.btnEliminarStore = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gridStore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarStore
            // 
            this.btnInsertarStore.Location = new System.Drawing.Point(78, 68);
            this.btnInsertarStore.Name = "btnInsertarStore";
            this.btnInsertarStore.Size = new System.Drawing.Size(101, 23);
            this.btnInsertarStore.TabIndex = 0;
            this.btnInsertarStore.Text = "Insertar Store";
            this.btnInsertarStore.UseVisualStyleBackColor = true;
            this.btnInsertarStore.Click += new System.EventHandler(this.btnInsertarStore_Click);
            // 
            // btnEliminarStore
            // 
            this.btnEliminarStore.Location = new System.Drawing.Point(258, 68);
            this.btnEliminarStore.Name = "btnEliminarStore";
            this.btnEliminarStore.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarStore.TabIndex = 1;
            this.btnEliminarStore.Text = "Eliminar Store";
            this.btnEliminarStore.UseVisualStyleBackColor = true;
            this.btnEliminarStore.Click += new System.EventHandler(this.btnEliminarStore_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(432, 68);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(107, 23);
            this.btnEliminar2.TabIndex = 2;
            this.btnEliminar2.Text = "Eliminar Store Ej.2";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(627, 68);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gridStore
            // 
            this.gridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStore.Location = new System.Drawing.Point(102, 149);
            this.gridStore.Name = "gridStore";
            this.gridStore.Size = new System.Drawing.Size(437, 221);
            this.gridStore.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridStore);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnEliminarStore);
            this.Controls.Add(this.btnInsertarStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarStore;
        private System.Windows.Forms.Button btnEliminarStore;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView gridStore;
    }
}

