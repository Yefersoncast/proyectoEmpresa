using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoEmpresa.Model;

namespace proyectoEmpresa.Controller
{
    public class ProductsController
    {
        ProductsModel dataBase;
    public ProductsController()
        {
            dataBase = new ProductsModel();
        }

    public string modifyProduct(int id, string name, double price, string category, string description)
    {
        string resultado = "";
        string query = "update productos set nombre= '" + name + "', precio= '" + price + "', categoria='" + category + "', descripcion='" + description + "' where idProducto= " + id + " ";

            string respuesta = dataBase.saveData(query);

        if (respuesta == "true")
        {
            resultado = "El producto ha sido modificado";
        }
        else if (respuesta == "false")
        {
            resultado = "El producto no ha sido modificado";
        }
        else
        {
            resultado = respuesta;
        }
        return resultado;
    }
  }
}
