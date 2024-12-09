using System.Drawing;
using System.Windows.Forms;

namespace LosGrisesForm
{
    partial class PersonalMan02
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblApM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cboUbigeo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 40);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(353, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 16);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(353, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(12, 43);
            this.lblApe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(87, 13);
            this.lblApe.TabIndex = 17;
            this.lblApe.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 19);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 262);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(103, 262);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(83, 23);
            this.btnGrabar.TabIndex = 22;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblApM
            // 
            this.lblApM.AutoSize = true;
            this.lblApM.Location = new System.Drawing.Point(12, 68);
            this.lblApM.Name = "lblApM";
            this.lblApM.Size = new System.Drawing.Size(89, 13);
            this.lblApM.TabIndex = 24;
            this.lblApM.Text = "Apellido Materno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contraseña: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInactivo);
            this.groupBox1.Controls.Add(this.optActivo);
            this.groupBox1.Location = new System.Drawing.Point(360, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 68);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // optInactivo
            // 
            this.optInactivo.AutoSize = true;
            this.optInactivo.Location = new System.Drawing.Point(7, 44);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(63, 17);
            this.optInactivo.TabIndex = 1;
            this.optInactivo.TabStop = true;
            this.optInactivo.Text = "Inactivo";
            this.optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            this.optActivo.AutoSize = true;
            this.optActivo.Location = new System.Drawing.Point(7, 20);
            this.optActivo.Name = "optActivo";
            this.optActivo.Size = new System.Drawing.Size(55, 17);
            this.optActivo.TabIndex = 0;
            this.optActivo.TabStop = true;
            this.optActivo.Text = "Activo";
            this.optActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ubigeo:";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(103, 65);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(353, 20);
            this.txtApeMat.TabIndex = 32;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(103, 92);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(353, 20);
            this.txtMail.TabIndex = 33;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(103, 119);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(242, 20);
            this.txtPass.TabIndex = 34;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(103, 146);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(242, 20);
            this.txtTel.TabIndex = 35;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(103, 174);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(242, 20);
            this.txtDir.TabIndex = 36;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(103, 232);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 20);
            this.txtDni.TabIndex = 37;
            // 
            // cboUbigeo
            // 
            this.cboUbigeo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbigeo.FormattingEnabled = true;
            this.cboUbigeo.Location = new System.Drawing.Point(103, 205);
            this.cboUbigeo.Name = "cboUbigeo";
            this.cboUbigeo.Size = new System.Drawing.Size(353, 21);
            this.cboUbigeo.TabIndex = 38;
            // 
            // PersonalMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 296);
            this.Controls.Add(this.cboUbigeo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApM);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Personal";
            this.Load += new System.EventHandler(this.AutorMan02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApe;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label lblApM;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private Label label6;
        private TextBox txtApeMat;
        private TextBox txtMail;
        private TextBox txtPass;
        private TextBox txtTel;
        private TextBox txtDir;
        private TextBox txtDni;
        private ComboBox cboUbigeo;
    }
}