using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaAsistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnIdioma_Click(object sender, EventArgs e)
        {
            LblNombre.Text = "Name";
            LblApP.Text = "First last name";
            LblApM.Text = "Second last name";
            LblEdad.Text = "Age";
            LblNacimiento.Text = "Birthday";
            LblCorreo.Text = "E-mail";
            LblTelefono.Text = "Cellphone";
            LblBoleta.Text = "ID";
            BtnBuscar.Text = "Search";
            BtnGuardar.Text = "Save";
            
        }
        private void BtnEspañol_Click(object sender, EventArgs e)
        {
            LblNombre.Text = "Nombre";
            LblApP.Text = "Apellido paterno";
            LblApM.Text = "Apellido materno";
            LblEdad.Text = "Edad";
            LblNacimiento.Text = "Fecha de nacimiento";
            LblCorreo.Text = "Correo";
            LblTelefono.Text = "Telefono";
            LblBoleta.Text = "Boleta";
            BtnBuscar.Text = "Buscar";
            BtnGuardar.Text = "Guardar";
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Comandos ObjCrear = new Comandos();
                Alumno nAlumno = new Alumno(TxtApellidoP.Text,TxtApellidoM.Text,TxtNombre.Text,int.Parse(TxtEdad.Text),TxtFechaN.Text,TxtCorreo.Text,TxtTelefono.Text);
                if (ObjCrear.Create(nAlumno) == 1)
                {
                    MessageBox.Show("Alumno agreado");
                }
                else
                {
                    MessageBox.Show("Alumno NO agreado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Comandos ObjRead = new Comandos();
                dataGridView1.DataSource = ObjRead.BuscarAlumno(int.Parse(TxtBoleta.Text));
                MessageBox.Show("Consulta Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                Comandos ObjRead = new Comandos();
                dataGridView1.DataSource = ObjRead.BuscarAlumno(int.Parse(TxtBoleta.Text));
                MessageBox.Show("Consulta Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnMostrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Comandos ObjRead = new Comandos();
                dataGridView1.DataSource = ObjRead.MostrarTabla();
                MessageBox.Show("Consulta Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            {
                Comandos Objdelete = new Comandos();
                if (Objdelete.eliminar(int.Parse(TxtBoleta.Text)) == 1)
                {
                    MessageBox.Show("Registro eliminado");
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
