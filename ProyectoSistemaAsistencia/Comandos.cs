using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaAsistencia
{
    internal class Comandos
    {
        public Comandos()
        { }
        SqlConnection ConexionSQL;
        SqlCommand CmdSQL;
        SqlDataReader ReadSQL;
        SqlDataAdapter DatosSQL;
        public int Create(Alumno nvoalumno)
        {
            int agregado = 0;
            using (ConexionSQL = ConexionBD.conectar())
            {
                ConexionSQL.Open();
                CmdSQL = new SqlCommand(string.Format("INSERT INTO ALUMNOS (PrimerA,SegundoA,NOMBRE,EDAD,FECHAN,CORREO,TELEFONO) values ('{0}', '{1}','{2}',{3},'{4}','{5}','{6}')", nvoalumno.PrimerA, nvoalumno.SegundoA, nvoalumno.Nombre, nvoalumno.Edad, nvoalumno.Fechan, nvoalumno.Correo, nvoalumno.Telefono), ConexionSQL);
                agregado = CmdSQL.ExecuteNonQuery();
                ConexionSQL.Close();
            }
            return agregado;
        }
        public DataTable MostrarTabla()
        {
            DataTable TablaAlumno = new DataTable();
            string Query = "SELECT * FROM ALUMNOS";
            using (ConexionSQL = ConexionBD.conectar())
            {
                ConexionSQL.Open();
                DatosSQL = new SqlDataAdapter(Query, ConexionSQL);
                DatosSQL.Fill(TablaAlumno);
                ConexionSQL.Close();
            }
            return TablaAlumno;
        }
        public List<Alumno> BuscarAlumno(int bol)
        {
            List<Alumno> ListaAlumno = new List<Alumno>();
            using (ConexionSQL = ConexionBD.conectar())
            {
                ConexionSQL.Open();
                CmdSQL = new SqlCommand(string.Format("SELECT BOLETA,PrimerA,SegundoA,NOMBRE,EDAD,FECHAN,CORREO,TELEFONO FROM ALUMNOS WHERE BOLETA LIKE '{0}'", bol), ConexionSQL);
                ReadSQL = CmdSQL.ExecuteReader();
                while (ReadSQL.Read())
                {
                    Alumno AlumnoEncontrado = new Alumno();
                    AlumnoEncontrado.Boleta = Convert.ToInt32(ReadSQL[0]);
                    AlumnoEncontrado.Nombre = ReadSQL[1].ToString();
                    AlumnoEncontrado.PrimerA = ReadSQL[1].ToString();
                    AlumnoEncontrado.SegundoA = ReadSQL[1].ToString();
                    AlumnoEncontrado.Fechan = ReadSQL[1].ToString();
                    AlumnoEncontrado.Correo = ReadSQL[1].ToString();
                    AlumnoEncontrado.Telefono = ReadSQL[1].ToString();
                    ListaAlumno.Add(AlumnoEncontrado);
                }
                ConexionSQL.Close();
            }
            return ListaAlumno;
        }

        public int eliminar(int bol)
        {
            int eliminado = 0;
            using (ConexionSQL = ConexionBD.conectar())
            {
                ConexionSQL.Open();
                CmdSQL = new SqlCommand(string.Format("Delete from ALUMNOS WHERE Boleta='{0}'", bol), ConexionSQL);
                eliminado = CmdSQL.ExecuteNonQuery();
                ConexionSQL.Close();
            }
            return eliminado;
        }
    }
}
