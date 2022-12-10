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
    internal class Alumno
    {
        //Atributos
        int boleta = 0;
        string nombre = string.Empty;
        string primerA = string.Empty;
        string segundoA = string.Empty;
        int edad = 0;
        string fechan = string.Empty;
        string correo = string.Empty;
        string telefono = string.Empty;

        //Propiedades
        public string PrimerA { get => primerA; set => primerA = value; }
        public string SegundoA { get => segundoA; set => segundoA = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Fechan { get => fechan; set => fechan = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Boleta { get => boleta; set => boleta = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Alumno()
        { }
        public Alumno(string nom, string Ap, string Am, int años, string fechaN, string mail, string tel)
        {
            Nombre = nom;
            PrimerA = Ap;
            SegundoA = Am;
            Edad = años;
            Fechan = fechaN;
            Correo = mail;
            Telefono = tel;
        }
    }
}
