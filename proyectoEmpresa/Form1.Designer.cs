namespace proyectoEmpresa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNickAdmin = new System.Windows.Forms.TextBox();
            this.btJoinAdmin = new System.Windows.Forms.Button();
            this.tbPassUser = new System.Windows.Forms.TextBox();
            this.tbNickUser = new System.Windows.Forms.TextBox();
            this.tbPassAdmin = new System.Windows.Forms.TextBox();
            this.btJoinUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNickAdmin
            // 
            this.tbNickAdmin.Location = new System.Drawing.Point(194, 115);
            this.tbNickAdmin.Name = "tbNickAdmin";
            this.tbNickAdmin.Size = new System.Drawing.Size(100, 20);
            this.tbNickAdmin.TabIndex = 0;
            // 
            // btJoinAdmin
            // 
            this.btJoinAdmin.Location = new System.Drawing.Point(206, 199);
            this.btJoinAdmin.Name = "btJoinAdmin";
            this.btJoinAdmin.Size = new System.Drawing.Size(75, 23);
            this.btJoinAdmin.TabIndex = 1;
            this.btJoinAdmin.Text = "Ingresar";
            this.btJoinAdmin.UseVisualStyleBackColor = true;
            // 
            // tbPassUser
            // 
            this.tbPassUser.Location = new System.Drawing.Point(400, 157);
            this.tbPassUser.Name = "tbPassUser";
            this.tbPassUser.Size = new System.Drawing.Size(100, 20);
            this.tbPassUser.TabIndex = 2;
            // 
            // tbNickUser
            // 
            this.tbNickUser.Location = new System.Drawing.Point(400, 115);
            this.tbNickUser.Name = "tbNickUser";
            this.tbNickUser.Size = new System.Drawing.Size(100, 20);
            this.tbNickUser.TabIndex = 3;
            // 
            // tbPassAdmin
            // 
            this.tbPassAdmin.Location = new System.Drawing.Point(194, 157);
            this.tbPassAdmin.Name = "tbPassAdmin";
            this.tbPassAdmin.Size = new System.Drawing.Size(100, 20);
            this.tbPassAdmin.TabIndex = 4;
            // 
            // btJoinUser
            // 
            this.btJoinUser.Location = new System.Drawing.Point(412, 201);
            this.btJoinUser.Name = "btJoinUser";
            this.btJoinUser.Size = new System.Drawing.Size(75, 23);
            this.btJoinUser.TabIndex = 5;
            this.btJoinUser.Text = "Ingresar";
            this.btJoinUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btJoinUser);
            this.Controls.Add(this.tbPassAdmin);
            this.Controls.Add(this.tbNickUser);
            this.Controls.Add(this.tbPassUser);
            this.Controls.Add(this.btJoinAdmin);
            this.Controls.Add(this.tbNickAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickAdmin;
        private System.Windows.Forms.Button btJoinAdmin;
        private System.Windows.Forms.TextBox tbPassUser;
        private System.Windows.Forms.TextBox tbNickUser;
        private System.Windows.Forms.TextBox tbPassAdmin;
        private System.Windows.Forms.Button btJoinUser;
    }
}

