using System.Drawing;
using System.Windows.Forms;

namespace LosGrisesForm
{
    partial class LibroMan03
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
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblFecPub = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodNum = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpPub = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEditorial
            // 
            this.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(76, 138);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(380, 21);
            this.cboEditorial.TabIndex = 60;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(12, 140);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 59;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(274, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 58;
            this.lblStock.Text = "Stock: ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(315, 113);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(141, 20);
            this.txtStock.TabIndex = 57;
            // 
            // lblFecPub
            // 
            this.lblFecPub.AutoSize = true;
            this.lblFecPub.Location = new System.Drawing.Point(12, 115);
            this.lblFecPub.Name = "lblFecPub";
            this.lblFecPub.Size = new System.Drawing.Size(101, 13);
            this.lblFecPub.TabIndex = 56;
            this.lblFecPub.Text = "Año de publicación:";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(10, 90);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(48, 13);
            this.lblEdicion.TabIndex = 55;
            this.lblEdicion.Text = "Edición: ";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(295, 62);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(162, 21);
            this.cboGenero.TabIndex = 54;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(249, 65);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 53;
            this.lblGenero.Text = "Género:";
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(76, 62);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(168, 21);
            this.cboAutor.TabIndex = 52;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(76, 88);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(380, 20);
            this.txtEdicion.TabIndex = 51;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(10, 65);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 50;
            this.lblAutor.Text = "Autor:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 177);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(267, 177);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(83, 23);
            this.btnGrabar.TabIndex = 47;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodNum
            // 
            this.lblCodNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodNum.Location = new System.Drawing.Point(225, 8);
            this.lblCodNum.Name = "lblCodNum";
            this.lblCodNum.Size = new System.Drawing.Size(44, 21);
            this.lblCodNum.TabIndex = 63;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(173, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 62;
            this.lblCodigo.Text = "Código:";
            // 
            // dtpPub
            // 
            this.dtpPub.CustomFormat = "yyyy";
            this.dtpPub.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPub.Location = new System.Drawing.Point(122, 113);
            this.dtpPub.Name = "dtpPub";
            this.dtpPub.ShowUpDown = true;
            this.dtpPub.Size = new System.Drawing.Size(148, 20);
            this.dtpPub.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInactivo);
            this.groupBox1.Controls.Add(this.optActivo);
            this.groupBox1.Location = new System.Drawing.Point(76, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 64);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
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
            // optInactivo
            // 
            this.optInactivo.AutoSize = true;
            this.optInactivo.Location = new System.Drawing.Point(7, 41);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(63, 17);
            this.optInactivo.TabIndex = 1;
            this.optInactivo.TabStop = true;
            this.optInactivo.Text = "Inactivo";
            this.optInactivo.UseVisualStyleBackColor = true;
            // 
            // LibroMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpPub);
            this.Controls.Add(this.lblCodNum);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblFecPub);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibroMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Libro";
            this.Load += new System.EventHandler(this.LibroMan03_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cboEditorial;
        private Label lblEditorial;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblFecPub;
        private Label lblEdicion;
        private ComboBox cboGenero;
        private Label lblGenero;
        private ComboBox cboAutor;
        private TextBox txtEdicion;
        private Label lblAutor;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label lblNombre;
        private Label lblCodNum;
        private Label lblCodigo;
        private DateTimePicker dtpPub;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
    }
}