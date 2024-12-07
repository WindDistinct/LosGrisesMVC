using LosGrisesForm.ProxyLibro;
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

    public partial class LibroMan01 : Form
    {
        ServicioLibroClient libro = new ServicioLibroClient();
        BindingSource bsDatos = new BindingSource();

        public LibroMan01()
        {
            InitializeComponent();
        }

        private void LibroMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            try
            {
                var listaLibros = libro.ListarLibro();

                bsDatos.DataSource = listaLibros;
                bsDatos.Filter = $"Titulo LIKE '%{strFiltro}%'";

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
                CargarDatos(txtBuscador.Text.Trim());
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
                LibroMan02 formulario = new LibroMan02();
                formulario.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de formulario:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un libro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LibroMan03 objLibroMan03 = new LibroMan03();

                String strCodigo = dtgDatos.CurrentRow.Cells["Id"].Value.ToString();
                objLibroMan03.Codigo = strCodigo;


                objLibroMan03.ShowDialog();

                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
