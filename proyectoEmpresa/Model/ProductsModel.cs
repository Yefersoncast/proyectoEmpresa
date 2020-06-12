using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoEmpresa.Model
{
   public class ProductsModel
    {
        string dirConnection = "server=127.0.0.1; user=root; password=; database=datos_proyecto";

        public string saveData(string query)
        {
            MySqlConnection connection = new MySqlConnection(dirConnection);
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.CommandTimeout = 60;

            try
            {
                //Abro la conexion para comenzar a ejecutar lo que necesito en la base de datos
                connection.Open();

                int numbResp= comand.ExecuteNonQuery();

                if (numbResp > -1)
                {
                    return "true";
                }

                //Cierro la conexion con la base de datos
                connection.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "false";
        }
        public string saveStockChanges(string query)
        {
            MySqlConnection connection = new MySqlConnection(dirConnection);
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.CommandTimeout = 60;

            try
            {
                //Abro la conexion para comenzar a ejecutar lo que necesito en la base de datos
                connection.Open();

                int numbResp = comand.ExecuteNonQuery();

                if (numbResp > -1)
                {
                    return "true";
                }

                //Cierro la conexion con la base de datos
                connection.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "false";
        }


    }
}
