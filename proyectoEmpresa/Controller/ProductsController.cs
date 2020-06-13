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
        string query = "update productos set nombre= '" + name + "', precio= '" + price + "', categoria='" + category + "', descripcion='" + description + "' where idProducto= '" + id + "' ";

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

        public string refreshStockProduct(int id, int stock)
        {
            string resultado = "";
            string query = "update productos set Cantidad= '" + stock + "' where idProducto= '" + id + "' ";

            string respuesta = dataBase.saveStockChanges(query);

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
        /*
         * @JuanJo Éste método se encarga de buscar el producto por su nombre y modificar su cantidad de unidades
         * en existencia y se usa en el boton de compra, se reutiliza el metodo de guardar cambios del controlador
         */
        public string refreshStockProductByname(string nameProd, int stock)
        {
            string resultado = "";
            string query = "update productos set Cantidad= '" + stock + "' where Nombre= '" + nameProd + "' ";

            string respuesta = dataBase.saveStockChanges(query);

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

        /*
         * @JuanJo Éste metodo mandará la peticion con los datos para crear una nueva linea 
         * en la tabla de detalles de factura (compra)
         */

        public string sendDetails (string idBill, int idProd, int unt, double tot)
        {
            string query = "INSERT INTO `compras`(`IdFactura`, `IdProducto`, `Unidades`, `ValorVenta`) VALUES ('" + idBill + "'," + idProd + "," + unt + "," + tot + ")";
            string resp = dataBase.fillDetails(query);
            return resp;
        }

    }
}
