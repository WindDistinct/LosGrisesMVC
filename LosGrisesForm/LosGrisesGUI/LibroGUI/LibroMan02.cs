using LosGrisesForm.ProxyAutor;
using LosGrisesForm.ProxyCliente;
using LosGrisesForm.ProxyEditorial;
using LosGrisesForm.ProxyGenero;
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
    public partial class LibroMan02 : Form
    {
        ServicioLibroClient lib = new ServicioLibroClient();
        LibroDC libro = new LibroDC();
        ServicioAutorClient aut = new ServicioAutorClient();
        ServicioEditorialClient edi = new ServicioEditorialClient();
        ServicioGeneroClient gen = new ServicioGeneroClient();

        public LibroMan02()
        {
            InitializeComponent();
        }

        private void LibroMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarAutor();

                CargarGenero();

                CargarEditorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de carga: " + ex.Message);
            }
        }

        private void CargarAutor()
        {
            cboAutor.DataSource = aut.ObtenerAutores();
            cboAutor.ValueMember = "AutorId";
            cboAutor.DisplayMember = "AutorNombreApellidos";
            cboAutor.SelectedValue = "--- Selecciones un autor ----";
        }

        private void CargarEditorial()
        {
            cboEditorial.DataSource = edi.ObtenerEditoriales();
            cboEditorial.ValueMember = "EditorialId";
            cboEditorial.DisplayMember = "EditorialNombre";
            cboEditorial.SelectedValue = "--- Selecciones una editorial ----";
        }

        private void CargarGenero()
        {
            cboGenero.DataSource = gen.ObtenerGeneros();
            cboGenero.ValueMember = "GeneroId";
            cboGenero.DisplayMember = "GeneroNombre";
            cboGenero.SelectedValue = "--- Selecciones un género ----";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    throw new Exception("El nombre es obligatorio.");
                }
                if (cboAutor.SelectedValue == null)
                {
                    throw new Exception("El autor es obligatorio.");
                }
                if (cboEditorial.SelectedValue == null)
                {
                    throw new Exception("La editorial es obligatoria.");
                }
                if (cboGenero.SelectedValue == null)
                {
                    throw new Exception("El genéro es obligatorio.");
                }
                if (txtEdicion.Text.Trim() == "")
                {
                    throw new Exception("La edición es obligatoria.");
                }
                if (txtStock.Text.Trim() == "")
                {
                    throw new Exception("El stock es obligatorio.");
                }

                libro.lib_nom = txtNombre.Text.Trim();
                libro.aut_id = Convert.ToInt16(cboAutor.SelectedValue);
                libro.edi_id = Convert.ToInt16(cboEditorial.SelectedValue);
                libro.gen_id = Convert.ToInt16(cboGenero.SelectedValue);
                libro.lib_edi = txtEdicion.Text.Trim();
                libro.lib_disp_stock = Convert.ToInt16(txtStock.Text.Trim());
                libro.lib_fec_pub = Convert.ToInt16(dtpPub.Value.Year);

                if (optActivo.Checked == true)
                {
                    libro.lib_state = 1;
                }
                else if (optInactivo.Checked == true)
                {
                    libro.lib_state = 0;
                }

                // Usuario Ingresado en Login
                libro.lib_user_reg = "admin";

                if (lib.InsertarLibro(libro) == true)
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

        private void NoNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
