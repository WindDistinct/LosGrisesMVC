using Libreria_BE;
using Libreria_BL;
using Libreria_GUI;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace LibreriaProyect
{
    public partial class Login : Form
    {
        PersonalBE objPersonalBE = new PersonalBE();
        PersonalBL objPersonalBL = new PersonalBL();
        public Login()
        {
            InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)
         {
            if (txtUser.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                objPersonalBE = objPersonalBL.ValidarUsuario(txtUser.Text.Trim(), txtPassword.Text.Trim());

                if (objPersonalBE.per_mail == txtUser.Text.Trim() &&
                    objPersonalBE.per_pass == txtPassword.Text.Trim())
                {
                    this.Hide();

                    // Cargamos el MDIPrincipal
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
