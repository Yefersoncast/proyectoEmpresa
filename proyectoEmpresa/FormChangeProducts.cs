using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace proyectoEmpresa
{
    public partial class FormChangeProducts : Form
    {
        public FormChangeProducts()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btShowProducts_Click(object sender, EventArgs e)
        {
            string categoria = cbSelectCategory.Text;
            string consulta = "SELECT idproducto, Nombre, Precio, Categoria, Descripcion FROM productos WHERE Categoria = '"+categoria+"'";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.CommandTimeout = 60;
            try
            {
                conexion.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataSet datos = new DataSet();
                adaptador.Fill(datos, "productos"); //Llena el adaptador con la info
                dgvProducts.DataSource = datos;         //Define de donde sacará la info
                dgvProducts.DataMember = "productos"; //Define la tabla que aparecerá
            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            {
                string name = tbSearchProduct.Text;
                string query = "SELECT idproducto, Nombre, Precio, Categoria, Descripcion FROM productos WHERE nombre = '" + name + "'";

                MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.CommandTimeout = 60;
                try
                {
                    conexion.Open();

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    DataSet data = new DataSet();
                    adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                    dgvProducts.DataSource = data;         //Define de donde sacará la info
                    dgvProducts.DataMember = "productos"; //Define la tabla que aparecerá
                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                }
            }
        }

        private void FormChangeProducts_Load(object sender, EventArgs e)
        {
            try
            {
                cbSelectCategory.Text = "Categorias";
                string consulta = "SELECT Categoria FROM productos";

                MySqlConnection conection = new MySqlConnection("server=127.0.0.1; user=root; password=; database=datos_proyecto");

                //command.CommandTimeout = 60;
                cbSelectCategory.Items.Clear();

                conection.Open();
                MySqlCommand command = new MySqlCommand(consulta, conection);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cbSelectCategory.Refresh();
                    cbSelectCategory.Items.Add(dr.GetValue(0).ToString());
                }
                conection.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btSendId_Click(object sender, EventArgs e)
        {
            gbChanges.Visible = true;
        }
    }
}
