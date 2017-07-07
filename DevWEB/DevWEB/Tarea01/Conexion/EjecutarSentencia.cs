using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web;
using System.Net.Http;

namespace Conexion
{
    public class EjecutarSentencia
    {               
        public EjecutarSentencia() { }

        public bool InsertarUsuario(string sentencia)
        { 
            SqlConnection conexionbd = new SqlConnection();
            SqlCommand comandobd;
            conexionbd.ConnectionString = "Data Source=192.168.1.89;Initial Catalog=Ingresos;user=mloera;password=Sierra117";
            comandobd = new SqlCommand(sentencia, conexionbd);
            conexionbd.Open();
            comandobd.ExecuteNonQuery();
            conexionbd.Close();

            return true;

        }
               

        public DataTable ConsultaUsuarioDT(string sentencia)
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
