using proyectoEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEmpresa.Controller
{
    class UsersController
    {

        UsersModel usersModel { get; }

        public UsersController()
        {
            usersModel = new UsersModel();

        }
        public string guadarDatos(string nombre, string apellido, string direccion, string telefono, string documento, string tipodedcumento, string correo, string contraseña)
        {
            string resultado;

            string query = "INSERT INTO clientes (Nombre,apellido,direccion,telefono,documento,tipo_de_documento,correo,contraseña) VALUES ('" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + documento + "','" + tipodedcumento + "','" + correo + "','" + contraseña + "')";

            string respuesta = usersModel.guardarDato(query);

            if (respuesta == "true")
            {
                resultado = "se han guardado los datos correctamente";
            }
            else if (respuesta == "false")
            {
                resultado = "error,no insertaron los datos";
            }

            return resultado = respuesta;

        }

        internal string guadarDatos(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
    }
}
