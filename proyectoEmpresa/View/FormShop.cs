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
        int chk, am, prc, name; string idBill;
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
         * @JuanJo Llena el comboBox con las categorias existentes y genera el id de el detalle de factura 
         */
        private void FormShop_Load(object sender, EventArgs e)
        {
            createIdDetails();
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
         * @JuanJo Éste método crea un id para el detalle de factura aleatoriamente asegurandose de que no
         * exista uno igual en la base de datos
         */
        private void createIdDetails()
        {
            string available = "false";
            Random rand = new Random();
            available = searchId(idBill);
            //Ciclo que hace la magia de generar ids aleatorios hasta que el espacio esté disponible (true)
            do
             {
              idBill =Convert.ToString( rand.Next(1, 1000));
              available = searchId(idBill);
             } while(available == "false");
          
        }

        /*
         * @JuanJo Método que busca si el id generado aleatoriamente ya existe
         * 
         */

        private string searchId(string idBill)
        {  
            try
            {
                string query = "select IdFactura from compras where IdFactura = '" + idBill + "'";

                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
                MySqlCommand comand = new MySqlCommand(query, connection);
                comand.CommandTimeout = 60;
                connection.Open();

                MySqlDataReader dr = comand.ExecuteReader();

                while(dr.Read())
                {
                    return "false";
                }
                
                connection.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "true";
           }

            /*
             * @JuanJo Método que confirmará la cantidad de existencias de producto disponibles para que 
             * el usuario realice la compra 
             */
            private int confirmStock(string nameProd)
        {
            string query = "select Cantidad from productos where Nombre = '" + nameProd + "'";
            int resp;


            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.CommandTimeout = 60;
            try
            {
                connection.Open();
                resp = (Int32)comand.ExecuteScalar();

            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
                resp = 0;
            }

            return (Int32)resp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //createIdDetails();
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
            double price, tot = 0, totRow ;
            string nameProd;
            int i, amount, actualStock, newStock, idProduct;

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
                            totRow = 0;
                            amount = Convert.ToInt32(dgvProducts.Rows[i].Cells[am].Value);
                            nameProd = Convert.ToString(dgvProducts.Rows[i].Cells[name].Value);
                            actualStock = confirmStock(nameProd);
                            newStock = actualStock - amount;
                    //La decision confirma que hayan suficientes unidades a la venta disponibles
                          if ( newStock >= 0)
                           {
                             updateStock(nameProd, newStock);
                             price = Convert.ToDouble(dgvProducts.Rows[i].Cells[prc].Value);
                             totRow = amount * price;
                             tot += totRow;
                             idProduct = searchIdByName(nameProd);
                             sendInfoToDetails(idBill, idProduct,amount,totRow);
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
         * @JuanJo Éste método enviará todos los datos necesarios para la creacion del detalle de factura
         */
        private void sendInfoToDetails(string idBill, int idProduct, int amount, double totRow )
        {
            ProductsController pController = new ProductsController();
            pController.sendDetails(idBill, idProduct, amount, totRow);
        }

        /*
         * @JuanJo En éste método se obtendrá el id del producto buscandolo por su nombre
         */
         private int searchIdByName(string name)
        {
                
                string query = "select IdProducto from productos where Nombre = '" + name + "'";
                int id;


                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; user=root; password=; database = datos_proyecto");
                MySqlCommand comand = new MySqlCommand(query, connection);
                comand.CommandTimeout = 60;
                try
                {
                    connection.Open();
                    id = (Int32)comand.ExecuteScalar();

                }
                catch (MySqlException r)
                {
                    MessageBox.Show(r.Message);
                    id = 0;
                }
            return (Int32)id;
        }

        /*
         * @JuanJo En éste método se actualiza la cantidad en stock de los productos
         * basandose en el metodo refreshStock creado para modificar el stock desde el inventario
         */
        private void updateStock(string nameProduct, int newStock)
        {
            ProductsController pController = new ProductsController();
            pController.refreshStockProductByname(nameProduct,newStock);
        }

    }
}
