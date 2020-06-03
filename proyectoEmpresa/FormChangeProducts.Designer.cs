namespace proyectoEmpresa
{
    partial class FormChangeProducts
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
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbChanges = new System.Windows.Forms.GroupBox();
            this.tbChangeNam = new System.Windows.Forms.TextBox();
            this.tbChangePrice = new System.Windows.Forms.TextBox();
            this.tbChangeDes = new System.Windows.Forms.TextBox();
            this.tbChangeCate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSendId = new System.Windows.Forms.Button();
            this.gbChanges.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(73, 144);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(114, 21);
            this.cbSelectCategory.TabIndex = 1;
            this.cbSelectCategory.Text = "Categorias";
            this.cbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cbSelectCategory_SelectedIndexChanged);
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(73, 118);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProduct.TabIndex = 2;
            this.tbSearchProduct.Text = "Buscar Producto";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProduct,
            this.nameProduct,
            this.descriptionProduct,
            this.priceProduct,
            this.category});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 408);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IdProduct
            // 
            this.IdProduct.Text = "ID";
            // 
            // nameProduct
            // 
            this.nameProduct.Text = "Nombre";
            // 
            // priceProduct
            // 
            this.priceProduct.DisplayIndex = 2;
            this.priceProduct.Text = "Precio";
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.DisplayIndex = 3;
            this.descriptionProduct.Text = "Descripcion";
            this.descriptionProduct.Width = 180;
            // 
            // category
            // 
            this.category.Text = "Categoria";
            this.category.Width = 106;
            // 
            // gbChanges
            // 
            this.gbChanges.Controls.Add(this.btSave);
            this.gbChanges.Controls.Add(this.label3);
            this.gbChanges.Controls.Add(this.label5);
            this.gbChanges.Controls.Add(this.label6);
            this.gbChanges.Controls.Add(this.tbChangeCate);
            this.gbChanges.Controls.Add(this.tbChangeDes);
            this.gbChanges.Controls.Add(this.label4);
            this.gbChanges.Controls.Add(this.tbChangePrice);
            this.gbChanges.Controls.Add(this.tbChangeNam);
            this.gbChanges.Location = new System.Drawing.Point(12, 227);
            this.gbChanges.Name = "gbChanges";
            this.gbChanges.Size = new System.Drawing.Size(277, 185);
            this.gbChanges.TabIndex = 4;
            this.gbChanges.TabStop = false;
            this.gbChanges.Text = "Cambios";
            this.gbChanges.Visible = false;
            // 
            // tbChangeNam
            // 
            this.tbChangeNam.Location = new System.Drawing.Point(76, 34);
            this.tbChangeNam.Name = "tbChangeNam";
            this.tbChangeNam.Size = new System.Drawing.Size(100, 20);
            this.tbChangeNam.TabIndex = 0;
            // 
            // tbChangePrice
            // 
            this.tbChangePrice.Location = new System.Drawing.Point(76, 61);
            this.tbChangePrice.Name = "tbChangePrice";
            this.tbChangePrice.Size = new System.Drawing.Size(100, 20);
            this.tbChangePrice.TabIndex = 1;
            // 
            // tbChangeDes
            // 
            this.tbChangeDes.Location = new System.Drawing.Point(76, 88);
            this.tbChangeDes.Name = "tbChangeDes";
            this.tbChangeDes.Size = new System.Drawing.Size(100, 20);
            this.tbChangeDes.TabIndex = 2;
            // 
            // tbChangeCate
            // 
            this.tbChangeCate.Location = new System.Drawing.Point(76, 115);
            this.tbChangeCate.Name = "tbChangeCate";
            this.tbChangeCate.Size = new System.Drawing.Size(187, 20);
            this.tbChangeCate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(188, 156);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modificar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btSendId
            // 
            this.btSendId.Location = new System.Drawing.Point(176, 194);
            this.btSendId.Name = "btSendId";
            this.btSendId.Size = new System.Drawing.Size(75, 23);
            this.btSendId.TabIndex = 7;
            this.btSendId.Text = "Enviar";
            this.btSendId.UseVisualStyleBackColor = true;
            // 
            // FormChangeProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSendId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbChanges);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.cbSelectCategory);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeProducts";
            this.Text = "FormChangeProducts";
            this.gbChanges.ResumeLayout(false);
            this.gbChanges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdProduct;
        private System.Windows.Forms.ColumnHeader nameProduct;
        private System.Windows.Forms.ColumnHeader descriptionProduct;
        private System.Windows.Forms.ColumnHeader priceProduct;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.GroupBox gbChanges;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChangeCate;
        private System.Windows.Forms.TextBox tbChangeDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbChangePrice;
        private System.Windows.Forms.TextBox tbChangeNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSendId;
    }
}