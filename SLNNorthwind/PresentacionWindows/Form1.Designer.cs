
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
            this.btnTraerShipperporId = new System.Windows.Forms.Button();
            this.lblShipperId = new System.Windows.Forms.Label();
            this.txtShipperId = new System.Windows.Forms.TextBox();
            this.gridShipper = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridShipper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerShipperporId
            // 
            this.btnTraerShipperporId.Location = new System.Drawing.Point(341, 106);
            this.btnTraerShipperporId.Name = "btnTraerShipperporId";
            this.btnTraerShipperporId.Size = new System.Drawing.Size(75, 23);
            this.btnTraerShipperporId.TabIndex = 0;
            this.btnTraerShipperporId.Text = "button1";
            this.btnTraerShipperporId.UseVisualStyleBackColor = true;
            this.btnTraerShipperporId.Click += new System.EventHandler(this.btnTraerShipperporId_Click);
            // 
            // lblShipperId
            // 
            this.lblShipperId.AutoSize = true;
            this.lblShipperId.Location = new System.Drawing.Point(147, 111);
            this.lblShipperId.Name = "lblShipperId";
            this.lblShipperId.Size = new System.Drawing.Size(55, 13);
            this.lblShipperId.TabIndex = 1;
            this.lblShipperId.Text = "Shipper Id";
            // 
            // txtShipperId
            // 
            this.txtShipperId.Location = new System.Drawing.Point(208, 106);
            this.txtShipperId.Name = "txtShipperId";
            this.txtShipperId.Size = new System.Drawing.Size(100, 20);
            this.txtShipperId.TabIndex = 2;
            // 
            // gridShipper
            // 
            this.gridShipper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShipper.Location = new System.Drawing.Point(157, 154);
            this.gridShipper.Name = "gridShipper";
            this.gridShipper.Size = new System.Drawing.Size(259, 159);
            this.gridShipper.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridShipper);
            this.Controls.Add(this.txtShipperId);
            this.Controls.Add(this.lblShipperId);
            this.Controls.Add(this.btnTraerShipperporId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridShipper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerShipperporId;
        private System.Windows.Forms.Label lblShipperId;
        private System.Windows.Forms.TextBox txtShipperId;
        private System.Windows.Forms.DataGridView gridShipper;
    }
}

