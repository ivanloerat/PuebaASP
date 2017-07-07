using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LoginUsuarioDA
    {

        public Entidades.Usuarios logearUsuario(string usuario, string pass)
        {
            Entidades.Usuarios usuarioLog = new Entidades.Usuarios();
            DataTable tablaResultado = new DataTable();
            Conexion.Conexion objCon = new Conexion.Conexion();
            tablaResultado = objCon.ejecutarConsulta("select cUsuId, cUsuAlias, cUsuNombre,cUsuPass,cUsuActivo, cUsuAdministrador from cUsuarios where cusualias = '" + usuario + "' and cUsuPass = '" + pass + "'");
            
            if (tablaResultado.Rows.Count > 0 )
            {
                
                usuarioLog.alias= tablaResultado.Rows[0]["cUsuAlias"].ToString();
                usuarioLog.nombre = tablaResultado.Rows[0]["cUsuNombre"].ToString();
                usuarioLog.pass = tablaResultado.Rows[0]["cUsuPass"].ToString(); ;
                if (bool.Parse(tablaResultado.Rows[0]["cUsuActivo"].ToString()) == true){
                    usuarioLog.activo = 1;
                }
                else usuarioLog.activo = 0;

                if (bool.Parse(tablaResultado.Rows[0]["cUsuAdministrador"].ToString()) == true)
                {
                    usuarioLog.administrador = 1;
                }
                else usuarioLog.administrador = 0;

               
            }
            else
            {
                usuarioLog = null;
            }

            return usuarioLog;
        }

    }
}
