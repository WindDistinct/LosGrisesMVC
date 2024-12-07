using LosGrisesForm.ProxyPersonal;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Windows.Forms;

namespace LosGrisesForm
{
    public partial class Login : Form
    {

        ServicioPersonalClient personal = new ServicioPersonalClient();

        public Login()
        {
            InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)
         {
            if (txtUser.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                if (personal.ValidarUsuario(txtUser.Text.Trim(), txtPassword.Text.Trim()))
                {
                    this.Hide();

                    MainMenu objMDI = new MainMenu();
                    objMDI.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese su usuario/contraseña",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
    }
}
