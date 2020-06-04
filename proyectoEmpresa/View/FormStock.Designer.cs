namespace proyectoEmpresa.View
{
    partial class FormStock
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
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.Location = new System.Drawing.Point(445, 27);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btSearchProduct.TabIndex = 15;
            this.btSearchProduct.Text = "Buscar";
            this.btSearchProduct.UseVisualStyleBackColor = true;
            this.btSearchProduct.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // btShowProducts
            // 
            this.btShowProducts.Location = new System.Drawing.Point(684, 30);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(116, 23);
            this.btShowProducts.TabIndex = 14;
            this.btShowProducts.Text = "Mostrar";
            this.btShowProducts.UseVisualStyleBackColor = true;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(339, 30);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProduct.TabIndex = 13;
            this.tbSearchProduct.Text = "Buscar Producto";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(553, 30);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(114, 21);
            this.cbSelectCategory.TabIndex = 12;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 59);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(776, 379);
            this.dgvProducts.TabIndex = 16;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btSearchProduct);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.cbSelectCategory);
            this.Name = "FormStock";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}