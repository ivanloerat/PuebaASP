using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Tarea01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string status = Request.QueryString["error"];
            if (status != null)
            {
                lblError.Visible = true;
                lblError.Text = "No ha iniciado Sesión";
            }
            if (Session["usuario"] != null)
                {
                    Response.Redirect("http://localhost:51954/Registro.aspx");
                }
            

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text; 
            string pass = txtPassword.Text;
                       

            Entidades.Usuarios miusuario = null;
            Negocio.ValidaUsuarioBU Validacion = new Negocio.ValidaUsuarioBU();

            miusuario = Validacion.LogInUsuario(usuario, pass);
            if (miusuario != null)
            {
                Session["usuario"] = miusuario.nombre;

                Response.Redirect("http://localhost:51954/Registro.aspx");
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "No existe un usuario con esos criterios";
                lblError.Visible = true;
            }

            }
        }
    }