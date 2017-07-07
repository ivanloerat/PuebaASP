using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string alias { get; set; }
        public string nombre { get; set; }
        public string pass { get; set; }
        public int activo { get; set; }
        public int administrador { get; set; }

    } 
    
    public class UsuarioLogIn
    {
        public string usuario { get; set; }
        public string pass { get; set; }

    }  

}
