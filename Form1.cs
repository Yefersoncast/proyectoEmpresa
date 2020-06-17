using Mysql.Model;
using MySql.Data.MySqlClient;
using ProyectoEmpresa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpresa
{
    public partial class Agregar_producto : Form
    {
        public Agregar_producto()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyController Ccontroller = new CompanyController();
            

            

           string Answer = Ccontroller.SaveProducts(tbName.Text, Convert.ToDouble(tbPrice.Text), tbDescription.Text, tbCategory.Text, Convert.ToInt32(tbQuantity.Text));


            MessageBox.Show(Answer);

            
           
            






        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btActualizarb_Click(object sender, EventArgs e)
        {
           }     
    }
}
