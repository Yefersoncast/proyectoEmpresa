using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoEmpresa.Model
{
    public class BillModel
    {
        string dirConnection = "server=127.0.0.1; user=root; password=; database=datos_proyecto";

        public string fillDetails(string query)
        {
            MySqlConnection connection = new MySqlConnection(dirConnection);
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.CommandTimeout = 60;

            try
            {
                connection.Open();

                int numbResp = comand.ExecuteNonQuery();

                if (numbResp > -1)
                {
                    return "true";
                }
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
