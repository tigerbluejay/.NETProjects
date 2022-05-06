
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
            this.btnEliminarStore.Location = new System.Drawing.Point(299, 68);
            this.btnEliminarStore.Name = "btnEliminarStore";
            this.btnEliminarStore.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarStore.TabIndex = 1;
            this.btnEliminarStore.Text = "Eliminar Store";
            this.btnEliminarStore.UseVisualStyleBackColor = true;
            this.btnEliminarStore.Click += new System.EventHandler(this.btnEliminarStore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarStore);
            this.Controls.Add(this.btnInsertarStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarStore;
        private System.Windows.Forms.Button btnEliminarStore;
    }
}

