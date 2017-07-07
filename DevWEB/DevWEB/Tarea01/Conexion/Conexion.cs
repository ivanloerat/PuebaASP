using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Conexion
    {
        public Conexion() { }

        public DataTable ejecutarConsulta(string sentencia)
        {
            SqlConnection conexionbd = new SqlConnection();
            SqlCommand comandobd;
            SqlDataAdapter DA = new SqlDataAdapter();
            DataTable DT = new DataTable();
            conexionbd.ConnectionString = "Data Source=192.168.1.89;Initial Catalog=Ingresos;user=mloera;password=Sierra117";
            comandobd = new SqlCommand(sentencia, conexionbd);
            DA.SelectCommand = comandobd;
            DA.Fill(DT);
            return DT;
        }
    }
}
