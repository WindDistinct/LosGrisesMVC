using LosGrisesForm.ProxyPersonal;
using System;
using System.Windows.Forms;

namespace LosGrisesForm
{
    public partial class PersonalMan01 : Form
    {
        BindingSource bsDatos = new BindingSource();
        ServicioPersonalClient per = new ServicioPersonalClient();

        public PersonalMan01()
        {
            InitializeComponent();
        }

        private void AutorMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {
            try
            {
                var listaPersonal = per.ListarPersonal();

                bsDatos.DataSource = listaPersonal;
                bsDatos.Filter = $"Apellido LIKE '%{strFiltro}%'";

                dtgDatos.DataSource = bsDatos;

                lblRegistros.Text = bsDatos.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonalMan02 formulario = new PersonalMan02();
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonalMan03 objPersonalMan03 = new PersonalMan03();
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objPersonalMan03.Codigo = strCodigo;

                objPersonalMan03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
