using proyectoEmpresa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEmpresa
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_surname.Text == "" || Txt_name.Text == "" || Txt_direc.Text == "" || Txt_Tell.Text == "" || Txt_documents.Text == "" || Txt_typedocuments.Text == "" ||
                Txt_correo.Text == "" || Txt_pass.Text == "" || Txt_2pass.Text == "")
            {
                MessageBox.Show("verificar informacion espacios vacios");
            }
            else
            {
                UsersController escontroler = new UsersController();

                if (Txt_pass.Text == Txt_2pass.Text)
                {
                    string respuesta = escontroler.guadarDatos(Txt_name.Text, txt_surname.Text, Txt_direc.Text, Txt_Tell.Text, Txt_documents.Text,
                        Txt_typedocuments.Text, Txt_correo.Text, Txt_pass.Text);
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("verificar contraseña", "advartencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void Txt_Tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo numeros", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Formregist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form register = new FormLogin();
            register.Show();
            this.Close();
        }
    }
}
