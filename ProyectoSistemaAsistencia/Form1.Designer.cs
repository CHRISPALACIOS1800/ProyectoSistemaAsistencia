namespace ProyectoSistemaAsistencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnEspañol = new System.Windows.Forms.Button();
            this.BtnIngles = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtBoleta = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblBoleta = new System.Windows.Forms.Label();
            this.pROYECTODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtFechaN = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtApellidoM = new System.Windows.Forms.TextBox();
            this.TxtApellidoP = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblApM = new System.Windows.Forms.Label();
            this.LblApP = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTODataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BtnEspañol);
            this.panel4.Controls.Add(this.BtnIngles);
            this.panel4.Location = new System.Drawing.Point(37, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 187);
            this.panel4.TabIndex = 5;
            // 
            // BtnEspañol
            // 
            this.BtnEspañol.BackColor = System.Drawing.Color.Maroon;
            this.BtnEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEspañol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEspañol.Location = new System.Drawing.Point(30, 95);
            this.BtnEspañol.Name = "BtnEspañol";
            this.BtnEspañol.Size = new System.Drawing.Size(132, 66);
            this.BtnEspañol.TabIndex = 2;
            this.BtnEspañol.Text = "Cambiar Idioma";
            this.BtnEspañol.UseVisualStyleBackColor = false;
            this.BtnEspañol.Click += new System.EventHandler(this.BtnEspañol_Click);
            // 
            // BtnIngles
            // 
            this.BtnIngles.BackColor = System.Drawing.Color.Maroon;
            this.BtnIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngles.Location = new System.Drawing.Point(30, 23);
            this.BtnIngles.Name = "BtnIngles";
            this.BtnIngles.Size = new System.Drawing.Size(132, 66);
            this.BtnIngles.TabIndex = 1;
            this.BtnIngles.Text = "Change languaje";
            this.BtnIngles.UseVisualStyleBackColor = false;
            this.BtnIngles.Click += new System.EventHandler(this.BtnIdioma_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.BtnMostrar);
            this.panel3.Controls.Add(this.TxtBoleta);
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.LblBoleta);
            this.panel3.Location = new System.Drawing.Point(849, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 408);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 240);
            this.dataGridView1.TabIndex = 19;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(461, 342);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 45);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(17, 342);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(158, 45);
            this.BtnMostrar.TabIndex = 17;
            this.BtnMostrar.Text = "Mostrar datos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click_1);
            // 
            // TxtBoleta
            // 
            this.TxtBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoleta.Location = new System.Drawing.Point(106, 35);
            this.TxtBoleta.Name = "TxtBoleta";
            this.TxtBoleta.Size = new System.Drawing.Size(210, 31);
            this.TxtBoleta.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(209, 342);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(107, 45);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblBoleta
            // 
            this.LblBoleta.AutoSize = true;
            this.LblBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBoleta.Location = new System.Drawing.Point(12, 35);
            this.LblBoleta.Name = "LblBoleta";
            this.LblBoleta.Size = new System.Drawing.Size(73, 25);
            this.LblBoleta.TabIndex = 15;
            this.LblBoleta.Text = "Boleta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtTelefono);
            this.panel2.Controls.Add(this.TxtCorreo);
            this.panel2.Controls.Add(this.TxtFechaN);
            this.panel2.Controls.Add(this.TxtEdad);
            this.panel2.Controls.Add(this.TxtApellidoM);
            this.panel2.Controls.Add(this.TxtApellidoP);
            this.panel2.Controls.Add(this.TxtNombre);
            this.panel2.Controls.Add(this.LblTelefono);
            this.panel2.Controls.Add(this.LblCorreo);
            this.panel2.Controls.Add(this.LblNacimiento);
            this.panel2.Controls.Add(this.LblEdad);
            this.panel2.Controls.Add(this.LblApM);
            this.panel2.Controls.Add(this.LblApP);
            this.panel2.Controls.Add(this.LblNombre);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Location = new System.Drawing.Point(273, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 408);
            this.panel2.TabIndex = 4;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(256, 295);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(276, 31);
            this.TxtTelefono.TabIndex = 14;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(256, 248);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(276, 31);
            this.TxtCorreo.TabIndex = 13;
            // 
            // TxtFechaN
            // 
            this.TxtFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaN.Location = new System.Drawing.Point(256, 203);
            this.TxtFechaN.Name = "TxtFechaN";
            this.TxtFechaN.Size = new System.Drawing.Size(276, 31);
            this.TxtFechaN.TabIndex = 12;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(256, 154);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(276, 31);
            this.TxtEdad.TabIndex = 11;
            // 
            // TxtApellidoM
            // 
            this.TxtApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoM.Location = new System.Drawing.Point(256, 113);
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.Size = new System.Drawing.Size(276, 31);
            this.TxtApellidoM.TabIndex = 10;
            // 
            // TxtApellidoP
            // 
            this.TxtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoP.Location = new System.Drawing.Point(256, 72);
            this.TxtApellidoP.Name = "TxtApellidoP";
            this.TxtApellidoP.Size = new System.Drawing.Size(276, 31);
            this.TxtApellidoP.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(256, 29);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(276, 31);
            this.TxtNombre.TabIndex = 8;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTelefono.Location = new System.Drawing.Point(22, 301);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(96, 25);
            this.LblTelefono.TabIndex = 7;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCorreo.Location = new System.Drawing.Point(22, 248);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(77, 25);
            this.LblCorreo.TabIndex = 6;
            this.LblCorreo.Text = "Correo";
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNacimiento.Location = new System.Drawing.Point(22, 203);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(212, 25);
            this.LblNacimiento.TabIndex = 5;
            this.LblNacimiento.Text = "Fecha de nacimiento";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEdad.Location = new System.Drawing.Point(22, 160);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(62, 25);
            this.LblEdad.TabIndex = 4;
            this.LblEdad.Text = "Edad";
            // 
            // LblApM
            // 
            this.LblApM.AutoSize = true;
            this.LblApM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblApM.Location = new System.Drawing.Point(22, 116);
            this.LblApM.Name = "LblApM";
            this.LblApM.Size = new System.Drawing.Size(174, 25);
            this.LblApM.TabIndex = 3;
            this.LblApM.Text = "Apellido Materno";
            // 
            // LblApP
            // 
            this.LblApP.AutoSize = true;
            this.LblApP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblApP.Location = new System.Drawing.Point(22, 75);
            this.LblApP.Name = "LblApP";
            this.LblApP.Size = new System.Drawing.Size(170, 25);
            this.LblApP.TabIndex = 2;
            this.LblApP.Text = "Apellido Paterno";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNombre.Location = new System.Drawing.Point(22, 35);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(425, 342);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(107, 45);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Location = new System.Drawing.Point(37, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 170);
            this.panel1.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Maroon;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngresar.Location = new System.Drawing.Point(30, 54);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(132, 66);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROYECTODataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnIngles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblBoleta;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblNacimiento;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblApM;
        private System.Windows.Forms.Label LblApP;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIngresar;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TxtTelefono;
        public System.Windows.Forms.TextBox TxtCorreo;
        public System.Windows.Forms.TextBox TxtFechaN;
        public System.Windows.Forms.TextBox TxtEdad;
        public System.Windows.Forms.TextBox TxtApellidoM;
        public System.Windows.Forms.TextBox TxtApellidoP;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnEspañol;
        public System.Windows.Forms.TextBox TxtBoleta;
        private System.Windows.Forms.BindingSource pROYECTODataSetBindingSource;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

