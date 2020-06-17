using proyectoEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEmpresa.Controller
{
    public class BillController
    {

        BillModel billDB;

        public BillController()
        {
            billDB = new BillModel();
        }
         /*
         * @JuanJo Éste metodo mandará la peticion con los datos para crear una nueva linea 
         * en la tabla de detalles de factura (compra)
         */
        public string sendDetails(string idBill, int idProd, int unt, double tot)
        {
            string query = "INSERT INTO `compras`(`IdFactura`, `IdProducto`, `Unidades`, `ValorVenta`) VALUES ('" + idBill + "'," + idProd + "," + unt + "," + tot + ")";
            string resp = billDB.fillDetails(query);
            return resp;
        }










    }
}
