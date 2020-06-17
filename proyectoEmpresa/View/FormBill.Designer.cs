namespace proyectoEmpresa.View
{
    partial class FormBill
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
            this.lbTotAll = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotAll
            // 
            this.lbTotAll.AutoSize = true;
            this.lbTotAll.Location = new System.Drawing.Point(1, 437);
            this.lbTotAll.Name = "lbTotAll";
            this.lbTotAll.Size = new System.Drawing.Size(35, 13);
            this.lbTotAll.TabIndex = 1;
            this.lbTotAll.Text = "label1";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Location = new System.Drawing.Point(43, 436);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(51, 13);
            this.lbIdBill.TabIndex = 2;
            this.lbIdBill.Text = "idFactura";
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(12, 118);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(776, 150);
            this.dgvDetails.TabIndex = 3;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lbIdBill);
            this.Controls.Add(this.lbTotAll);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbTotAll;
        public System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}