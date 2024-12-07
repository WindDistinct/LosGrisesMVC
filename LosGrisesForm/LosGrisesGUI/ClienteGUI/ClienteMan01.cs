using LosGrisesForm.ProxyCliente;
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
    public partial class ClienteMan01 : Form
    {
        BindingSource bsDatos = new BindingSource();
        ServicioClienteClient cliente = new ServicioClienteClient();

        public ClienteMan01()
        {
            InitializeComponent();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(string strFiltro)
        {
            try
            {
                var listaClientes = cliente.ListarCliente();

                bsDatos.DataSource = listaClientes;
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

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan02 formulario = new ClienteMan02();
                formulario.ShowDialog();
                CargarDatos("");
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
                if (dtgDatos.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClienteMan03 objClienteMan03 = new ClienteMan03();

                string strCodigo = dtgDatos.CurrentRow.Cells["Id"].Value.ToString();
                objClienteMan03.Codigo = Convert.ToInt16(strCodigo);

 
                objClienteMan03.ShowDialog();

                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Boton Cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // No borrar
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClienteMan01_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
