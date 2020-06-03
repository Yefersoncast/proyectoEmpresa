namespace proyectoEmpresa
{
    partial class FormMenuAdmin
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
            this.btChangeProducts = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChangeProducts
            // 
            this.btChangeProducts.Location = new System.Drawing.Point(307, 46);
            this.btChangeProducts.Name = "btChangeProducts";
            this.btChangeProducts.Size = new System.Drawing.Size(178, 70);
            this.btChangeProducts.TabIndex = 0;
            this.btChangeProducts.Text = "Modificar";
            this.btChangeProducts.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(307, 160);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(178, 70);
            this.btAddProduct.TabIndex = 1;
            this.btAddProduct.Text = "Agregar producto";
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // btStock
            // 
            this.btStock.Location = new System.Drawing.Point(307, 278);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(178, 70);
            this.btStock.TabIndex = 2;
            this.btStock.Text = "Inventario";
            this.btStock.UseVisualStyleBackColor = true;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStock);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btChangeProducts);
            this.Name = "FormMenuAdmin";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChangeProducts;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btStock;
    }
}