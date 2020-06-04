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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void btSearchProduct_Click(object sender, EventArgs e)
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

        private void btShowProducts_Click(object sender, EventArgs e)
        {
            string category = cbSelectCategory.Text;
            string query = "SELECT * FROM productos WHERE Categoria = '"+category+"'";

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comando = new MySqlCommand(query, conexion);
            
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                DataSet data = new DataSet();
                adaptador.Fill(data, "productos"); //Llena el adaptador con la info
                dgvProducts.DataSource = data;         //Define de donde sacará la info
                dgvProducts.DataMember = "productos"; //Define la tabla que aparecerá

                DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                dgvProducts.Columns.Add(tbc);
                tbc.HeaderText = "Agregar";
                tbc.Name = "tbc";

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            try
            {
                cbSelectCategory.Text = "Categorias";
                string consulta = "SELECT Categoria FROM productos";

                MySqlConnection conection = new MySqlConnection("server=127.0.0.1; user=root; password=; database=datos_proyecto");

                
                cbSelectCategory.Items.Clear();

                conection.Open();
                MySqlCommand command = new MySqlCommand(consulta, conection);
                command.CommandTimeout = 60;
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
    }
    }

