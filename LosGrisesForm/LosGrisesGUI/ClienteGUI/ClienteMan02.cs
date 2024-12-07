using LosGrisesForm.ProxyCliente;
using LosGrisesForm.ProxyUbigeo;
using System;
using System.Windows.Forms;

namespace LosGrisesForm
{
    public partial class ClienteMan02 : Form
    {
        ServicioClienteClient cliente = new ServicioClienteClient();
        ServicioUbigeoClient ubg = new ServicioUbigeoClient();
        ClienteDC clienteDC = new ClienteDC();
        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            optHombre.Checked = true;
            optActivo.Checked = true;
        }

        private void CargarUbigeo()
        {
            cboUbigeo.DataSource = ubg.ObtenerUbigeos();
            cboUbigeo.ValueMember = "UbigeoId";
            cboUbigeo.DisplayMember = "UbigeoDesc";
            cboUbigeo.SelectedValue = "--- Selecciones un ubigeo ----";
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
                if (txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("La dirección es obligatorio.");
                }
                if (txtTelefono.Text.Trim() == "")
                {
                    throw new Exception("El teléfono es obligatorio.");
                }
                if (txtDni.Text.Trim() == "")
                {
                    throw new Exception("El DNI es obligatorio.");
                }
                if (txtEmail.Text.Trim() == "")
                {
                    throw new Exception("El correo electrónico es obligatorio.");
                }

                clienteDC.cli_nom = txtNombre.Text.Trim();
                clienteDC.cli_ape = txtApellido.Text.Trim();
                clienteDC.cli_dir = txtDireccion.Text.Trim();
                clienteDC.cli_tel = txtTelefono.Text.Trim();
                clienteDC.cli_dni = txtDni.Text.Trim();
                clienteDC.cli_mail = txtEmail.Text.Trim();
                clienteDC.cli_fec_nac_serializado = "2002-02-14";

                if (optHombre.Checked == true)
                {
                    clienteDC.cli_sex = Convert.ToString('H');
                }
                else if (optMujer.Checked == true)
                {
                    clienteDC.cli_sex = Convert.ToString('F');
                }
                else
                {
                    throw new Exception("Debe seleecionar un sexo.");
                }

                if (optActivo.Checked == true)
                {
                    clienteDC.cli_state = 1;
                }
                else if (optInactivo.Checked == true)
                {
                    clienteDC.cli_state = 0;
                }

                clienteDC.ubg_id = cboUbigeo.SelectedValue.ToString();

                // Usuario Ingresado en Login
                clienteDC.cli_user_reg = "admin";

                if (cliente.InsertarCliente(clienteDC) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        // no borrar
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
