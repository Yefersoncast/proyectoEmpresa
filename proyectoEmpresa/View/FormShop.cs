using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using proyectoEmpresa.Controller;

namespace proyectoEmpresa.View
{
    public partial class FormShop : Form
    {
        int chk, am, prc, name;
        public FormShop()
        {
            InitializeComponent();
        }
        /*
         * @JuanJo Metodo que busca el producto por su nombre y lo imprime en el dgv
         */
        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            string name = tbSearchProduct.Text;
            string query = "SELECT idproducto, Nombre, Precio, Categoria, Descripcion FROM productos WHERE nombre ='"+name+"'";

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
        /*
         * @JuanJo Llena el comboBox con las categorias existentes
         */
        private void FormShop_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT distinct Categoria FROM productos";

                MySqlConnection conection = new MySqlConnection("server=127.0.0.1; user=root; password=; database=datos_proyecto");
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
        /*
         * @JuanJo Muestra ciertos atributos de los productos buscados por su categoria
         */
        private void btShowProducts_Click(object sender, EventArgs e)
        {

            string category = cbSelectCategory.Text;
            string query = "SELECT Nombre, Precio, Descripcion FROM productos WHERE Categoria = '"+category+"'";

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

                //Agrega 2 nuevas columnas a la tabla pero no permite que se sigan agregando mediante la decision
                if (dgvProducts.Columns.Count < 5)
                {
                    DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                    dgvProducts.Columns.Add(tbc);
                    tbc.HeaderText = "Cantidad";
             
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    dgvProducts.Columns.Add(chk);
                    chk.HeaderText = "Comprar";
                    dgvProducts.AllowUserToAddRows = false;
                }
                
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        /*
         * @JuanJo Este es el método con el que el cliente confirma la compra y se encarga de leer las casillas
         * guardando primero el indice de su columna y luego accediendo a el valor de cada celda en esa columna
         * para leerlo y hacer las tareas necesarias con dicho dato
         */

        private void btAddToCar_Click(object sender, EventArgs e)
        {
            bool check;
            double price, tot=0;
            string nameProd;
            int i, amount, actualStock, newStock;

            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                if (column.HeaderText.Equals("Comprar"))
                {
                    chk = column.Index;
                }
                if (column.HeaderText.Equals("Cantidad"))
                {
                    am = column.Index;
                }
                if (column.HeaderText.Equals("Precio"))
                {
                    prc = column.Index;
                }
                if (column.HeaderText.Equals("Nombre"))
                {
                    name = column.Index;
                }
            }

                    for (i = 0; i < dgvProducts.Rows.Count; i++)
                    {
                        check = Convert.ToBoolean(dgvProducts.Rows[i].Cells[chk].Value);
                        if (check == true)
                        {
                            amount = Convert.ToInt32(dgvProducts.Rows[i].Cells[am].Value);
                            nameProd = Convert.ToString(dgvProducts.Rows[i].Cells[name].Value);
                            actualStock = confirmStock(nameProd);
                            newStock = actualStock - amount;
                          if ( newStock >= 0)
                           {
                             price = Convert.ToDouble(dgvProducts.Rows[i].Cells[prc].Value);
                             tot += amount * price;
                           }
                          else
                           {
                        MessageBox.Show("Lo sentimos la cantidad de " + nameProd + " requerida es superior" +
                            " a nuestras existencias, por favor escoja una cantidad inferior o igual a " + actualStock+" unidades");
                           }
                            
                        }
                    }
            lbpruebaTotal.Text = "" + tot;
        }

        /*
         * @JuanJo Pequeño método que confirmará la cantidad de existencias de producto disponibles para que 
         * el usuario realice la compra 
         */

        private int confirmStock(string nameProd)
        {
            string query = "select Cantidad from productos where Nombre = '" + nameProd + "'"; string what;
            int response=0;

            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader rd = comand.ExecuteReader();
                what = rd.GetString(query);
            }
            catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }

            return response;
        }
        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Contar cantidad de filas y columnas(desde 1) comenzando desde cero
            // lbPruebaPrecio.Text = ""+dgvProducts.Rows.GetLastRow(DataGridViewElementStates.Displayed);
            //lbpruebaCantidad.Text = ""+dgvProducts.Columns.Count;
            //Obtiene el contenido de la celda pero comienza las columnas desde cero
            //lbpruebaEstado.Text = "" + dgvProducts.Rows[0].Cells[2].Value;
            //lbContenidoCheckBox.Text = "" + Convert.ToBoolean(dgvProducts.Rows[2].Cells[4].Value);
            //lbPruebaContenido.Text = "" + dgvProducts.Rows[2].Cells[3].Value;
            //Casillas de prueba
            //lbpruebaEstado.Text = ""+ Convert.ToString(dgvProducts.Rows[0].Cells[4].Value);
            /*lbPruebaPrecio.Text = "" + dgvProducts.Rows[1].Cells[1].Value;
            lbpruebaCantidad.Text = "" + dgvProducts.Rows[1].Cells[3].Value;
            */
        }

    }
}
