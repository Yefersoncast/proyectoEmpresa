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
using proyectoEmpresa.Controller;

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
                string consulta = "SELECT distinct Categoria FROM productos";

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

        /*
         * @JuanJo Éste metodo permite que al hacer click todos los datos recolectados por las cajas de texto
         * sean enviados a la base de datos reemplazando la informacion en el id de producto correspondiente
        */
        private void btSave_Click(object sender, EventArgs e)
        {
            string name, valMessage;
            int id = Convert.ToInt32(tbFindId.Text);
            bool available;

            name = tbChangeNam.Text;
            available = searchName(name);
            if (available == true)
            {
                //Se limpia cualquier error que exista si es un segundo click
                    eProvider.Clear();
                    makeChanges(name);
                    
                
            }
            else
            {
                eProvider.SetError(tbChangeNam, "Por favor cambiar el nombre");
                valMessage =Convert.ToString( MessageBox.Show("El nombre: "+"'"+name+"'"+" ya existe","ALERTA!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation));
                if (valMessage == "OK")
                {
                    makeChanges(name);
                }
                else
                {
                    tbChangeNam.Text = null;
                }
            }

        }

        /*
         * @JuanJo Metodo que hará los cambios en el producto con el fin de que el codigo que se repite pueda
         * ser reutilizado
         */
         private void makeChanges(string name)
        {
            string category, description, query, valPrice;
            double price;

            int id = Convert.ToInt32(tbFindId.Text);

            valPrice = validatePrice(tbChangePrice.Text);
            if (valPrice == "true")
            {
                price = Convert.ToDouble(tbChangePrice.Text);
                category = tbChangeCat.Text;
                description = tbChangeDesc.Text;
                //Mando la informacion al controlador para que le haga la peticion al modelo
                ProductsController pController = new ProductsController();
                query = pController.modifyProduct(id, name, price, category, description);

                MessageBox.Show(query);
                gbChanges.Visible = false;
                tbChangeNam.Text = null;
                tbChangeCat.Text = null;
                tbChangeDesc.Text = null;
                tbChangePrice.Text = null;
            }
        }
        /*
         * @JuanJo Metodo que se asegura de que todos los caracteres de precio sean numericos
         */
         private string validatePrice(string price)
        {
            string response = "";
                
            foreach(char character in price)
            {
                if(char.IsDigit(character))
                {
                    response = "true";
                    
                }
                else
                {
                    eProvider.SetError(tbChangePrice, "El precio solo debe contener numeros");
                    response = "false";
                    break;
                }
            }

            return response;
        }
        /*
         * @JuanJo Método que verifica si el nombre ingresado por el usuario coincide con
         * cualquier otro producto ya existente.
         */
        private bool searchName(string name)
        {
            try
            {
                string query = "select Nombre from productos where Nombre = '" + name + "'";
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
                MySqlCommand comand = new MySqlCommand(query, connection);
                comand.CommandTimeout = 60;

                connection.Open();
                MySqlDataReader dr = comand.ExecuteReader();

                while (dr.Read())
                {
                    return false;
                }

                connection.Close();
            }
            catch (Exception e)
            {
             string exc= e.Message;
                MessageBox.Show(exc);
            }

            return true;

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.Show();
        }
        /*
         * @JuanJo En este método se programa la instruccion de cancelar la modificacion 
         * devolviendo todo el contenido de los texbox a un estado vacio y ocultando el groupbox de 
         * modificaciones
         */
        private void btCancelMod_Click(object sender, EventArgs e)
        {
            tbFindId.Text = null;
            gbChanges.Visible = false;
            tbChangeNam.Text = null;
            tbChangeCat.Text = null;
            tbChangeDesc.Text = null;
            tbChangePrice.Text = null;
        }
    }
}
