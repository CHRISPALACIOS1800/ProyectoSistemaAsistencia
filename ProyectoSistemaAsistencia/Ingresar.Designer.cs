
namespace ProyectoSistemaAsistencia
{
    partial class Ingresar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.TxtPass_ingreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUser_Ingreso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnIngreso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnIngreso.Location = new System.Drawing.Point(261, 124);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(127, 52);
            this.BtnIngreso.TabIndex = 11;
            this.BtnIngreso.Text = "Ingresar";
            this.BtnIngreso.UseVisualStyleBackColor = false;
            // 
            // TxtPass_ingreso
            // 
            this.TxtPass_ingreso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtPass_ingreso.Location = new System.Drawing.Point(136, 87);
            this.TxtPass_ingreso.Name = "TxtPass_ingreso";
            this.TxtPass_ingreso.PasswordChar = '*';
            this.TxtPass_ingreso.Size = new System.Drawing.Size(252, 31);
            this.TxtPass_ingreso.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // TxtUser_Ingreso
            // 
            this.TxtUser_Ingreso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtUser_Ingreso.Location = new System.Drawing.Point(97, 50);
            this.TxtUser_Ingreso.Name = "TxtUser_Ingreso";
            this.TxtUser_Ingreso.Size = new System.Drawing.Size(291, 31);
            this.TxtUser_Ingreso.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESAR";
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.TxtPass_ingreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUser_Ingreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.TextBox TxtPass_ingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUser_Ingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}