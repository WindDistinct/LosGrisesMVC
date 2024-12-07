using LosGrisesForm.ProxyPersonal;
using LosGrisesForm.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosGrisesForm
{
    public partial class PersonalMan02 : Form
    {
        ServicioPersonalClient per = new ServicioPersonalClient();
        PersonalDC personal = new PersonalDC();
        ServicioUbigeoClient ubg = new ServicioUbigeoClient();

        public PersonalMan02()
        {
            InitializeComponent();
        }

        private void AutorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            optActivo.Checked = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    throw new Exception("El nombre es obligatorio.");
                }
                if (txtApellido.Text.Trim() == "")
                {
                    throw new Exception("El apellido es obligatorio.");
                }
                if (txtApeMat.Text.Trim() == "")
                {
                    throw new Exception("El apellido materno es obligatorio.");
                }
                if (txtDir.Text.Trim() == "")
                {
                    throw new Exception("La dirección es obligatoria.");
                }
                if (txtDni.Text.Trim() == "")
                {
                    throw new Exception("El DNI es obligatorio.");
                }
                if (txtMail.Text.Trim() == "")
                {
                    throw new Exception("El correo es obligatorio.");
                }
                if (txtPass.Text.Trim() == "")
                {
                    throw new Exception("La contraseña es obligatorio.");
                }
                if (txtTel.Text.Trim() == "")
                {
                    throw new Exception("El telefono es obligatorio.");
                }

                personal.per_nom = txtNombre.Text.Trim();
                personal.per_ape_pat = txtApellido.Text.Trim();
                personal.per_ape_mat = txtApeMat.Text.Trim();
                personal.per_dir = txtDir.Text.Trim();
                personal.per_dni = txtDni.Text.Trim();
                personal.per_mail = txtMail.Text.Trim();
                personal.per_pass = txtPass.Text.Trim(); 
                personal.per_tel = txtTel.Text.Trim();
                personal.per_fec_ing = Convert.ToDateTime("02-02-2000");

                personal.ubg_id = cboUbigeo.SelectedValue.ToString();

                if (optActivo.Checked == true)
                {
                    personal.per_state = 1;
                }
                else if (optInactivo.Checked == true)
                {
                    personal.per_state = 0;
                }

                // Usuario Ingresado en Login
                personal.per_user_reg = "admin";

                if (per.InsertarPersonal(personal) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: No se insertó el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void CargarUbigeo()
        {
            cboUbigeo.DataSource = ubg.ObtenerUbigeos();
            cboUbigeo.ValueMember = "UbigeoId";
            cboUbigeo.DisplayMember = "UbigeoDesc";
            cboUbigeo.SelectedValue = "--- Selecciones un ubigeo ----";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
