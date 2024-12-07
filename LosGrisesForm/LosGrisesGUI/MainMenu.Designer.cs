using System.Drawing;
using System.Windows.Forms;

namespace LosGrisesForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiMantenimientos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiMantenimientos
            // 
            this.smiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiPersonal,
            this.smiLibro,
            this.smiCliente});
            this.smiMantenimientos.Name = "smiMantenimientos";
            this.smiMantenimientos.Size = new System.Drawing.Size(106, 20);
            this.smiMantenimientos.Text = "Mantenimientos";
            // 
            // smiPersonal
            // 
            this.smiPersonal.Name = "smiPersonal";
            this.smiPersonal.Size = new System.Drawing.Size(180, 22);
            this.smiPersonal.Text = "Personal";
            this.smiPersonal.Click += new System.EventHandler(this.smiPersonal_Click);
            // 
            // smiLibro
            // 
            this.smiLibro.Name = "smiLibro";
            this.smiLibro.Size = new System.Drawing.Size(180, 22);
            this.smiLibro.Text = "Libros";
            this.smiLibro.Click += new System.EventHandler(this.smiLibros_Click);
            // 
            // smiCliente
            // 
            this.smiCliente.Name = "smiCliente";
            this.smiCliente.Size = new System.Drawing.Size(180, 22);
            this.smiCliente.Text = "Clientes";
            this.smiCliente.Click += new System.EventHandler(this.smiClientes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem smiMantenimientos;
        private ToolStripMenuItem smiPersonal;
        private ToolStripMenuItem smiLibro;
        private ToolStripMenuItem smiCliente;
    }
}