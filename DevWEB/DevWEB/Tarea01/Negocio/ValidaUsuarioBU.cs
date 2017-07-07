using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidaUsuarioBU
    {
        public ValidaUsuarioBU()
        {

        }

        public String ValidaUsuario(Entidades.Usuarios usuario)
        {
            try
            {
                string mensaje = string.Empty;
                if (usuario.alias == null){
                    return mensaje = "El nombre no puede estar vacio";
                }
                else if (usuario.nombre == null) {
                    return mensaje = "El apellido no puede estar vacio";
                }
                else if (usuario.pass == null) {
                    return mensaje = "El correo no puede estar vacio";
                }
                else {
                    Datos.RegistraUsuario RegUsuario = new Datos.RegistraUsuario();
                    if (RegUsuario.InsertarUsuario(usuario) == true)
                    {
                        return "Insertado con exito";
                    }
                    else
                    {
                        return "Ocurrio un error";
                    }
                }
            }
            catch (Exception e)
            {
                string a = e.Message;
                return "Ocurrio un error";
            }
        }

        public Entidades.Usuarios LogInUsuario(string usuario, string pass)
        {
            Datos.LoginUsuarioDA login = new Datos.LoginUsuarioDA();
            Entidades.Usuarios usuariologueado = new Entidades.Usuarios();

            if (usuario != null && pass != null)
            {
                usuariologueado = login.logearUsuario(usuario, pass);

            }
            return usuariologueado;

        }
    }
}



