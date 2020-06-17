using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace Mysql.Model
{
    public class Model
    {
        string connstring = ("Server=localhost;database=proyecto_empresa;UID=root;password=");

        public string SaveData(string query)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connstring);


            MySqlCommand commandDatabase = new MySqlCommand(query, mySqlConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                mySqlConnection.Open();

                int numeroRespuesta = commandDatabase.ExecuteNonQuery();

                if (numeroRespuesta > -1)
                {
                    return "True.";
                }


                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }



            return "False";

        }
    }
}

        
     












    



