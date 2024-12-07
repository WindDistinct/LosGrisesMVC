using System;
using System.Windows.Forms;

namespace LosGrisesForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void smiClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan01 clientes = new ClienteMan01();
                clientes.MdiParent = this;
                clientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void smiLibros_Click(object sender, EventArgs e)
        {
            try
            {
                LibroMan01 libros = new LibroMan01();
                libros.MdiParent = this;
                libros.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void smiPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                PersonalMan01 personal = new PersonalMan01();
                personal.MdiParent = this;
                personal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
