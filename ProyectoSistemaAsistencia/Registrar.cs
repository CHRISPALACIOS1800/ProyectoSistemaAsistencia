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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Registro_Click(object sender, EventArgs e)
        {
            Usuario OBJUser = new Usuario();
            try
            {
                if (TxtUser_Registro.Text.Trim() != ""
                    && TxtPass_Registro.Text.Trim() != "")
                {
                    OBJUser.Login(TxtUser_Registro.Text, TxtPass_Registro.Text);
                    if (Program.ID != "")
                    {
                        MessageBox.Show("Sesión iniciada correctamente", "MENSAJE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña erroneos", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUser_Registro.Clear();
                        TxtPass_Registro.Clear();
                        TxtRepetirPass_Registro.Clear();
                        TxtUser_Registro.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ocurrió :((" + ex, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Ingresar FRMIngresar = new Ingresar();
            FRMIngresar.ShowDialog();
        }
    }
}
