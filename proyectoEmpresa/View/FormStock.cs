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
using proyectoEmpresa.Controller;

namespace proyectoEmpresa.View
{
    public partial class FormStock : Form
    {
        int col, id, oldSt;
        public FormStock()
        {
            InitializeComponent();
        }

        /*
         * @JuanJo Lee lo que haya dentro del texBox de buscar el producto que coincida con el nombre escrito
         */
        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            string name = tbSearchProduct.Text;
            string query = "SELECT * FROM productos WHERE nombre = '" + name + "'";

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
            string query = "SELECT * FROM productos WHERE Categoria = '" + category + "'";

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

                //Se asegura de que la columna agregar no se repita al exeder el limite de columnas
                if (dgvProducts.Columns.Count < 7)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProducts.Columns.Add(tbc);
                    tbc.HeaderText = "Agregar";
                    tbc.Name = "tbc";
                    dgvProducts.AllowUserToAddRows = false;
                }
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
        /*
         *@JuanJo Al cargar el formulario se mandará una peticion a la base de datos para que 
         * recoja todas las categorias y las almacene en el comboBox
         */
        private void FormStock_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT distinct Categoria FROM productos";

                MySqlConnection conection = new MySqlConnection("server=127.0.0.1; user=root; password=; database=datos_proyecto");

                //Se asegura de que el comboBox no tenga elementos dentro
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

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            int i, nStock, oStock, idProd;
            //Accedo al indice en el que se encuentra cada columna recorriendolas y comparando cadenas 
            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                if (column.HeaderText.Equals("Agregar"))
                {
                    col = column.Index;
                }
                if (column.HeaderText.Equals("idProducto"))
                {
                    id = column.Index;
                }
                if(column.HeaderText.Equals("Cantidad"))
                {
                    oldSt = column.Index;
                }
            }
            //Recorro las filas y leo el valor de inventario antigüo, el nuevo y el id del producto correspondiente 
                    for (i = 0; i < dgvProducts.Rows.Count; i++)
                    {
                      oStock = Convert.ToInt32(dgvProducts.Rows[i].Cells[oldSt].Value);
                      nStock = Convert.ToInt32(dgvProducts.Rows[i].Cells[col].Value) + oStock;
                      idProd = Convert.ToInt32(dgvProducts.Rows[i].Cells[id].Value);
                      sendNewStock(idProd, nStock);
                    }
        }
        /*
         * @JuanJo Metodo que recibe el id que corresponde al producto junto con la nueva cantidad en 
         * inventario para mandarle los parámetros al metodo en el controlador que se encarga de hacer 
         * la peticion
         */
        private void sendNewStock (int idProd, int nStock)
        {
            string query;
            ProductsController pController = new ProductsController();
            query = pController.refreshStockProduct(idProd, nStock);

        }

        /*
         * @JuanJo devuelve al usuario al menú de administrador
         */
        private void btReturn_Click(object sender, EventArgs e)
        {
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.Show();
        }
    }
}
