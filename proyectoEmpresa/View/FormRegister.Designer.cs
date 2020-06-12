namespace proyectoEmpresa
{
    partial class FormRegister
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
        this.Txt_2pass = new System.Windows.Forms.TextBox();
        this.Txt_pass = new System.Windows.Forms.TextBox();
        this.Txt_correo = new System.Windows.Forms.TextBox();
        this.Txt_typedocuments = new System.Windows.Forms.TextBox();
        this.Txt_documents = new System.Windows.Forms.TextBox();
        this.Txt_Tell = new System.Windows.Forms.TextBox();
        this.Txt_direc = new System.Windows.Forms.TextBox();
        this.txt_surname = new System.Windows.Forms.TextBox();
        this.Txt_name = new System.Windows.Forms.TextBox();
        this.Btn_register = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // Txt_2pass
        // 
        this.Txt_2pass.Location = new System.Drawing.Point(590, 206);
        this.Txt_2pass.Name = "Txt_2pass";
        this.Txt_2pass.Size = new System.Drawing.Size(100, 20);
        this.Txt_2pass.TabIndex = 20;
        // 
        // Txt_pass
        // 
        this.Txt_pass.Location = new System.Drawing.Point(484, 206);
        this.Txt_pass.Name = "Txt_pass";
        this.Txt_pass.Size = new System.Drawing.Size(100, 20);
        this.Txt_pass.TabIndex = 19;
        // 
        // Txt_correo
        // 
        this.Txt_correo.Location = new System.Drawing.Point(484, 168);
        this.Txt_correo.Name = "Txt_correo";
        this.Txt_correo.Size = new System.Drawing.Size(100, 20);
        this.Txt_correo.TabIndex = 18;
        // 
        // Txt_typedocuments
        // 
        this.Txt_typedocuments.Location = new System.Drawing.Point(484, 126);
        this.Txt_typedocuments.Name = "Txt_typedocuments";
        this.Txt_typedocuments.Size = new System.Drawing.Size(100, 20);
        this.Txt_typedocuments.TabIndex = 17;
        // 
        // Txt_documents
        // 
        this.Txt_documents.Location = new System.Drawing.Point(484, 84);
        this.Txt_documents.Name = "Txt_documents";
        this.Txt_documents.Size = new System.Drawing.Size(100, 20);
        this.Txt_documents.TabIndex = 16;
        // 
        // Txt_Tell
        // 
        this.Txt_Tell.Location = new System.Drawing.Point(137, 206);
        this.Txt_Tell.Name = "Txt_Tell";
        this.Txt_Tell.Size = new System.Drawing.Size(100, 20);
        this.Txt_Tell.TabIndex = 15;
        this.Txt_Tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tell_KeyPress);
        // 
        // Txt_direc
        // 
        this.Txt_direc.Location = new System.Drawing.Point(137, 168);
        this.Txt_direc.Name = "Txt_direc";
        this.Txt_direc.Size = new System.Drawing.Size(100, 20);
        this.Txt_direc.TabIndex = 14;
        // 
        // txt_surname
        // 
        this.txt_surname.Location = new System.Drawing.Point(137, 126);
        this.txt_surname.Name = "txt_surname";
        this.txt_surname.Size = new System.Drawing.Size(100, 20);
        this.txt_surname.TabIndex = 13;
        // 
        // Txt_name
        // 
        this.Txt_name.Location = new System.Drawing.Point(137, 84);
        this.Txt_name.Name = "Txt_name";
        this.Txt_name.Size = new System.Drawing.Size(100, 20);
        this.Txt_name.TabIndex = 12;
        // 
        // Btn_register
        // 
        this.Btn_register.Location = new System.Drawing.Point(232, 327);
        this.Btn_register.Name = "Btn_register";
        this.Btn_register.Size = new System.Drawing.Size(105, 39);
        this.Btn_register.TabIndex = 11;
        this.Btn_register.Text = "Registrarse";
        this.Btn_register.UseVisualStyleBackColor = true;
        this.Btn_register.Click += new System.EventHandler(this.Btn_registrar_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(67, 90);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(42, 13);
        this.label1.TabIndex = 22;
        this.label1.Text = "nombre";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(67, 126);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(43, 13);
        this.label2.TabIndex = 23;
        this.label2.Text = "apellido";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(66, 168);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(52, 13);
        this.label3.TabIndex = 24;
        this.label3.Text = "direcciom";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(67, 206);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(45, 13);
        this.label4.TabIndex = 25;
        this.label4.Text = "telefono";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(418, 87);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(60, 13);
        this.label5.TabIndex = 26;
        this.label5.Text = "documento";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(383, 133);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(95, 13);
        this.label6.TabIndex = 27;
        this.label6.Text = "tipo de documento";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(418, 175);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(37, 13);
        this.label7.TabIndex = 28;
        this.label7.Text = "correo";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(418, 213);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(60, 13);
        this.label8.TabIndex = 29;
        this.label8.Text = "contraseña";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(400, 327);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(105, 39);
        this.button1.TabIndex = 30;
        this.button1.Text = "iniciar sesion";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // Formregist
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.Txt_2pass);
        this.Controls.Add(this.Txt_pass);
        this.Controls.Add(this.Txt_correo);
        this.Controls.Add(this.Txt_typedocuments);
        this.Controls.Add(this.Txt_documents);
        this.Controls.Add(this.Txt_Tell);
        this.Controls.Add(this.Txt_direc);
        this.Controls.Add(this.txt_surname);
        this.Controls.Add(this.Txt_name);
        this.Controls.Add(this.Btn_register);
        this.Name = "Formregist";
        this.Text = "Formregist";
        this.Load += new System.EventHandler(this.Formregist_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox Txt_2pass;
    private System.Windows.Forms.TextBox Txt_pass;
    private System.Windows.Forms.TextBox Txt_correo;
    private System.Windows.Forms.TextBox Txt_typedocuments;
    private System.Windows.Forms.TextBox Txt_documents;
    private System.Windows.Forms.TextBox Txt_Tell;
    private System.Windows.Forms.TextBox Txt_direc;
    private System.Windows.Forms.TextBox txt_surname;
    private System.Windows.Forms.TextBox Txt_name;
    private System.Windows.Forms.Button Btn_register;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button1;
}
}