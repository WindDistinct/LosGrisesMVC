using System.Drawing;
using System.Windows.Forms;

namespace LosGrisesForm
{
    partial class LibroMan02
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblFecPub = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.dtpPub = new System.Windows.Forms.DateTimePicker();
            this.estado = new System.Windows.Forms.GroupBox();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 16);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 169);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(264, 169);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(83, 23);
            this.btnGrabar.TabIndex = 30;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(23, 43);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 33;
            this.lblAutor.Text = "Autor:";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(89, 66);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(380, 20);
            this.txtEdicion.TabIndex = 34;
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(89, 41);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(168, 21);
            this.cboAutor.TabIndex = 35;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(261, 43);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 36;
            this.lblGenero.Text = "Género:";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(308, 41);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(162, 21);
            this.cboGenero.TabIndex = 37;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(23, 68);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(48, 13);
            this.lblEdicion.TabIndex = 38;
            this.lblEdicion.Text = "Edición: ";
            // 
            // lblFecPub
            // 
            this.lblFecPub.AutoSize = true;
            this.lblFecPub.Location = new System.Drawing.Point(23, 94);
            this.lblFecPub.Name = "lblFecPub";
            this.lblFecPub.Size = new System.Drawing.Size(101, 13);
            this.lblFecPub.TabIndex = 39;
            this.lblFecPub.Text = "Año de publicación:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(293, 91);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(176, 20);
            this.txtStock.TabIndex = 41;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(252, 94);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 42;
            this.lblStock.Text = "Stock: ";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(25, 119);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 43;
            this.lblEditorial.Text = "Editorial:";
            // 
            // cboEditorial
            // 
            this.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(89, 116);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(380, 21);
            this.cboEditorial.TabIndex = 44;
            // 
            // dtpPub
            // 
            this.dtpPub.CustomFormat = "yyyy";
            this.dtpPub.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPub.Location = new System.Drawing.Point(125, 91);
            this.dtpPub.Name = "dtpPub";
            this.dtpPub.ShowUpDown = true;
            this.dtpPub.Size = new System.Drawing.Size(122, 20);
            this.dtpPub.TabIndex = 46;
            // 
            // estado
            // 
            this.estado.Controls.Add(this.optInactivo);
            this.estado.Controls.Add(this.optActivo);
            this.estado.Location = new System.Drawing.Point(89, 143);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(96, 60);
            this.estado.TabIndex = 47;
            this.estado.TabStop = false;
            this.estado.Text = "Estado";
            // 
            // optActivo
            // 
            this.optActivo.AutoSize = true;
            this.optActivo.Location = new System.Drawing.Point(6, 19);
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
            this.optInactivo.Location = new System.Drawing.Point(7, 39);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(63, 17);
            this.optInactivo.TabIndex = 1;
            this.optInactivo.TabStop = true;
            this.optInactivo.Text = "Inactivo";
            this.optInactivo.UseVisualStyleBackColor = true;
            // 
            // LibroMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 211);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.dtpPub);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibroMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Libro";
            this.Load += new System.EventHandler(this.LibroMan02_Load);
            this.estado.ResumeLayout(false);
            this.estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label lblNombre;
        private Label lblAutor;
        private TextBox txtEdicion;
        private ComboBox cboAutor;
        private Label lblGenero;
        private ComboBox cboGenero;
        private Label lblEdicion;
        private Label lblFecPub;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblEditorial;
        private ComboBox cboEditorial;
        private TextBox txtFecPub;
        private DateTimePicker dtpPub;
        private GroupBox estado;
        private RadioButton optInactivo;
        private RadioButton optActivo;
    }
}