using Mysql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmpresa.Controller
{
    public class CompanyController
    {
        Model  ModeloProducto;

        public CompanyController()
        {
            ModeloProducto = new Model();
        }

        public string SaveProducts(string Name, double Price, string description, string category)
        {
            string Outcome = "";

            string query = "INSERT INTO `producto`(`Nombre`, `Precio`, `Descripcion`, `Categoria`) VALUES('" + Name + "','" + Price + "','" + description + "','" + category + "')";
                
                
                //"INSERT INTO `producto`( `nombre`, `precio`, `descripcion`, `categoria`) VALUES ('" + nombre + "','" + precio + "'," + descripcion + "','" + categoria + ")";

            string Answer = ModeloProducto.SaveData(query);

            if (Answer == "True")
            {
                Outcome = "Se han guardado los datos";
            }
            else if (Answer == "False")
            {
                Outcome = "Error, no se han insertado los datos";
            }
            else
            {
                Outcome = Answer;
            }



            return Outcome;



        }
    }
}

