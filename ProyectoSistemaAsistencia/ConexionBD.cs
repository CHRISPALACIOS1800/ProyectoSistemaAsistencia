using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace ProyectoSistemaAsistencia
{
    internal class ConexionBD
    {
        public ConexionBD()
        { }
        public static SqlConnection conectar()
        {
            string cadenaCon = "Data Source=.;Initial Catalog=PROYECTO;Integrated Security=True";
            SqlConnection miConexion = new SqlConnection(cadenaCon);
            return miConexion;
        }
    }
}
