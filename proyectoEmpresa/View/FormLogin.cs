using MySql.Data.MySqlClient;
using proyectoEmpresa.View;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btJoinUser_Click(object sender, EventArgs e)
        {
            MySqlConnection conectaruser = new MySqlConnection("server=localhost; database=login; UID=root; password=;");
            conectaruser.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectaruser;

            codigo.CommandText = ("Select *from logindatos where nombre ='" + tbNickUser.Text + "'and contraseña = '" + tbPassUser.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("bienvenido");
                Form register = new FormShop();
                register.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
            conectaruser.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void btJoinAdmin_Click(object sender, EventArgs e)
        {
            int admin = 0;
            MySqlConnection conectaradmin = new MySqlConnection("server=localhost; database=login; UID=root; password=;");
            conectaradmin.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectaradmin;

            codigo.CommandText = ("Select *from logindatos where nombre ='" + tbNickAdmin.Text + "'and contraseña = '" + tbPassAdmin.Text + "' and tipo = '" + admin + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("bienvenido");
                Form register = new FormMenuAdmin();
                register.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
            conectaradmin.Close();

            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.Show();
        }

        private void tbNickAdmin_Enter(object sender, EventArgs e)
        {
            if (tbNickAdmin.Text == "Usuario administrador")
            {
                tbNickAdmin.Text = "";
                tbNickAdmin.ForeColor = Color.Black;
            }
        }

        private void tbPassAdmin_Leave(object sender, EventArgs e)
        {
            if (tbPassAdmin.Text == "")
            {
                tbPassAdmin.Text = "Contraseña";
                tbPassAdmin.ForeColor = Color.Red;
                tbPassAdmin.UseSystemPasswordChar = false;
            }
        }

        private void tbPassAdmin_Enter(object sender, EventArgs e)
        {
            if (tbPassAdmin.Text == "Contraseña")
            {
                tbPassAdmin.Text = "";
                tbPassAdmin.ForeColor = Color.Black;
                tbPassAdmin.UseSystemPasswordChar = true;
                tbPassAdmin.UseSystemPasswordChar = true;
            }
        }

        private void tbNickAdmin_Leave(object sender, EventArgs e)
        {
            if (tbNickAdmin.Text == "")
            {
                tbNickAdmin.Text = "Usuario administrador";
                tbNickAdmin.ForeColor = Color.Red;
            }
        }

        private void tbNickUser_Enter(object sender, EventArgs e)
        {

            if (tbNickUser.Text == "Usuario")
            {
                tbNickUser.Text = "";
                tbNickUser.ForeColor = Color.Black;
            }

        }

        private void tbNickUser_Leave(object sender, EventArgs e)
        {

            if (tbNickUser.Text == "")
            {
                tbNickUser.Text = "Usuario";
                tbNickUser.ForeColor = Color.Red;
            }


        }

        private void tbPassUser_Enter(object sender, EventArgs e)
        {

            if (tbPassUser.Text == "Contraseña")
            {
                tbPassUser.Text = "";
                tbPassUser.ForeColor = Color.Black;
                tbPassUser.UseSystemPasswordChar = true;
            }
        }

        private void tbPassUser_Leave(object sender, EventArgs e)
        {

            if (tbPassUser.Text == "")
            {
                tbPassUser.Text = "Contraseña";
                tbPassUser.ForeColor = Color.Red;
                tbPassUser.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
