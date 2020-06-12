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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btChangeProducts_Click(object sender, EventArgs e)
        {
            FormChangeProducts formChangeProducts = new FormChangeProducts();
            formChangeProducts.Show();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.Show();
        }
    }
}
