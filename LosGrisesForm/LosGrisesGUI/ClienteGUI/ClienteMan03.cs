using LosGrisesForm.ProxyCliente;
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
    public partial class ClienteMan03 : Form
    {
        ServicioClienteClient cliente = new ServicioClienteClient();
        ServicioUbigeoClient ubg = new ServicioUbigeoClient();
        ClienteDC clienteDC = new ClienteDC();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        public Int16 Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            clienteDC = cliente.ConsultarCliente(Codigo);
            try
            {
                lblCodNum.Text = clienteDC.cli_id.ToString();
                txtNombre.Text = clienteDC.cli_nom;
                txtApellido.Text = clienteDC.cli_ape;
                txtDireccion.Text = clienteDC.cli_dir;
                txtTelefono.Text = clienteDC.cli_tel;
                txtDni.Text = clienteDC.cli_dni;
                txtEmail.Text = clienteDC.cli_mail;

                String ubg_id = clienteDC.ubg_id;
                CargarUbigeo();

                //dtpFecNac.Value = objClienteBE.cli_fec_nac;
                //clienteDC.cli_fec_nac_serializado = "2000-02-14";

                if (clienteDC.cli_sex == Convert.ToString('H'))
                {
                    optHombre.Checked = true;
                }
                else
                {
                    optMujer.Checked = true;
                }

                if (clienteDC.cli_state == 0)
                {
                    optInactivo.Checked = true;
                }
                else
                {
                    optActivo.Checked = true;
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
            cboUbigeo.SelectedValue = clienteDC.ubg_id;
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

                clienteDC.cli_id = Convert.ToInt16(lblCodNum.Text);
                clienteDC.cli_nom = txtNombre.Text.Trim();
                clienteDC.cli_ape = txtApellido.Text.Trim();
                clienteDC.cli_dir = txtDireccion.Text.Trim();
                clienteDC.cli_tel = txtTelefono.Text.Trim();
                clienteDC.cli_dni = txtDni.Text.Trim();
                clienteDC.cli_mail = txtEmail.Text.Trim();

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
                else
                {
                    throw new Exception("Debe seleecionar un sexo.");
                }


                clienteDC.ubg_id = cboUbigeo.SelectedValue.ToString();
                //clienteDC.cli_fec_nac_serializado = Convert.ToDateTime(dtpFecNac.Value);
                clienteDC.cli_fec_nac_serializado = "2000-02-14";

                // Usuario Ingresado en Login
                clienteDC.cli_user_mod = "admin";

                if (cliente.ActualizarCliente(clienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se editó el registro.");

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

        
    }
}
