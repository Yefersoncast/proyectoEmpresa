using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoEmpresa.View
{
    public partial class FormBill : Form
    {
        double totBill; string idBill;
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            totBill = Convert.ToDouble(lbTotAll.Text);
            idBill = lbIdBill.Text;

            string query = "SELECT * FROM compras WHERE IdFactura = '" + idBill + "'";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "compras");
                dgvDetails.DataSource = data;
                dgvDetails.DataMember = "compras";
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }

        }
    }
}
