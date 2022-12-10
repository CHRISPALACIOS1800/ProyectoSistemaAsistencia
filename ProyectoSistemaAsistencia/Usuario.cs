using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lIBRERÍAS
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//Librería App Config
using System.Configuration;

namespace ProyectoSistemaAsistencia
{
    class Usuario
    {
        SqlConnection ConexiónSQL;
        SqlCommand CmdSQL;
        SqlDataReader ReadSQL;
        SqlDataAdapter DatosSQL;
        public void Login(string usuario_Login, string pass_Login)
        {
            string Query = "SELECT ID FROM Usuarios WHERE nombre='" + usuario_Login +
                "' AND contraseña='" + pass_Login + "'";
            try
            {
                CmdSQL = new SqlCommand(Query, ConexiónSQL);
                ConexiónSQL.Open();
                ReadSQL = CmdSQL.ExecuteReader();
                if (ReadSQL.Read())
                {
                    Program.ID = ReadSQL["ID"].ToString();
                }
                else
                {
                    Program.ID = "";
                }
            }
            catch
            {

            }
        }
    }
}
