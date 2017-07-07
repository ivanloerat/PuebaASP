using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Tarea01
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {

                Session["usuario"] = "registro";
            }
            else
            {
                Response.Redirect("http://localhost:51954/Login.aspx?error=1");
            }
            
        }

        [WebMethod()]
        public static string RegistraUsuario(string alias, string nombre, string password, int tipo)
        {
            string mensaje = string.Empty;

            try
            {
                Entidades.Usuarios usuario = new Entidades.Usuarios();
                usuario.alias = alias;
                usuario.nombre = nombre;
                usuario.pass = password;
                usuario.activo= 1;
                usuario.administrador = tipo;
                Negocio.ValidaUsuarioBU validarusuarioBU = new Negocio.ValidaUsuarioBU();
                mensaje = validarusuarioBU.ValidaUsuario(usuario);

            }
            catch
            {
                return "Error";
            }
            return mensaje;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("http://localhost:51954/Login.aspx");
        }
    }
}