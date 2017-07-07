using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RegistraUsuario
    {
        public RegistraUsuario()
        {
         

        }

        public bool InsertarUsuario(Entidades.Usuarios usuario)
        {
            string sentencia = "Insert into cUsuarios(cUsuAlias, cUsuNombre,cUsuPass,cUsuActivo, cUsuAdministrador) values('" + usuario.alias+"','"+usuario.nombre+"','"+usuario.pass+"',"+usuario.activo+","+usuario.administrador+")";
            Conexion.EjecutarSentencia ejecutacomando = new Conexion.EjecutarSentencia();
            if (ejecutacomando.InsertarUsuario(sentencia) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

    }
}
