using LosGrisesForm.ProxyAutor;
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
    public partial class LibroMan03 : Form
    {
        ServicioLibroClient lib = new ServicioLibroClient();
        LibroDC libro = new LibroDC();
        ServicioAutorClient aut = new ServicioAutorClient();
        ServicioEditorialClient edi = new ServicioEditorialClient();
        ServicioGeneroClient gen = new ServicioGeneroClient();
        BindingSource bs = new BindingSource();

        public LibroMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void LibroMan03_Load(object sender, EventArgs e)
        {
            try
            {
                libro = lib.ConsultarLibro(Convert.ToInt16(Codigo));

                CargarAutor();
                cboAutor.SelectedValue = libro.aut_id;

                CargarGenero();
                cboGenero.SelectedValue = libro.gen_id;

                CargarEditorial(); 
                cboEditorial.SelectedValue = libro.edi_id;

                lblCodNum.Text = libro.lib_id.ToString();
                txtNombre.Text = libro.lib_nom;
                cboAutor.SelectedValue = libro.aut_id.ToString();
                cboEditorial.SelectedValue = libro.edi_id.ToString();
                cboGenero.SelectedValue = libro.gen_id.ToString();
                txtEdicion.Text = libro.lib_edi;
                int year = libro.lib_fec_pub;
                DateTime publicacion = new DateTime(year, 1, 1); // Crear una fecha con el año y el 1 de enero
                dtpPub.Value = publicacion;
                txtStock.Text = libro.lib_disp_stock.ToString();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

                libro.lib_id = Convert.ToInt16(lblCodNum.Text);
                libro.lib_nom = txtNombre.Text.Trim();
                libro.aut_id = Convert.ToInt16(cboAutor.SelectedValue);
                libro.edi_id = Convert.ToInt16(cboEditorial.SelectedValue);
                libro.gen_id = Convert.ToInt16(cboGenero.SelectedValue);
                libro.lib_edi = txtEdicion.Text.Trim();
                libro.lib_disp_stock = Convert.ToInt16(txtStock.Text);
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
                libro.lib_user_mod = "admin";

                if (lib.ActualizarLibro(libro) == true)
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

        private void NoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
