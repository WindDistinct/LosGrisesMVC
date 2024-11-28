using LosGrisesWeb.ProxyAutor;
using LosGrisesWeb.ProxyCliente;
using LosGrisesWeb.ProxyEditorial;
using LosGrisesWeb.ProxyGenero;
using LosGrisesWeb.ProxyLibro;
using LosGrisesWeb.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LosGrisesWeb.Controllers
{
    public class LibroController : Controller
    {

        ServicioLibroClient servicioLibro = new ServicioLibroClient();

        // GET: Libro
        public ActionResult Index()
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Libro" },
                { "aut_nom", "Nombre Autor" },
                { "aut_ape", "Apellido Autor" },
                { "gen_desc", "Genero" },
                { "lib_edi", "Edicion" },
                { "edi_nom", "Editorial" },
                { "lib_disp_stock", "Stock" },
                { "lib_state", "status" }
            };
            var libros = servicioLibro.ListarLibro();
            return View(libros);
        }


        //Details
        public ActionResult Details(int id)
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Libro" },
                { "aut_nom", "Nombre Autor" },
                { "aut_ape", "Apellido Autor" },
                { "gen_desc", "Genero" },
                { "lib_edi", "Edicion" },
                { "edi_nom", "Nom Editorial" },
                { "lib_disp_stock", "Stock" },
                { "lib_state", "status" }
            };
            var libro = servicioLibro.ConsultarLibro((short)id);
            return View(libro);
        }


        //GET: Create
        public ActionResult Create()
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Libro" },
                { "aut_id", "Autor" },
                { "gen_id", "Genero" },
                { "lib_edi", "Edicion" },
                { "lib_fec_pub", "Fec Publicacion" },
                { "lib_disp_stock", "Stock" },
                { "edi_id", "Editorial" }
            };

            
            ServicioEditorialClient servicioEditorial = new ServicioEditorialClient();
            ServicioAutorClient servicioAutor = new ServicioAutorClient();
            ServicioGeneroClient servicioGenero = new ServicioGeneroClient();
            var editoriales = servicioEditorial.ObtenerEditoriales();
            var autores = servicioAutor.ObtenerAutores();
            var generos = servicioGenero.ObtenerGeneros();
            ViewBag.aut_id = new SelectList(autores, "AutorId", "AutorNombreApellidos");
            ViewBag.edi_id = new SelectList(editoriales, "EditorialId", "EditorialNombre");
            ViewBag.gen_id = new SelectList(generos, "GeneroId", "GeneroNombre");

            return View();
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibroDC libro)
        {
            if (ModelState.IsValid)
            {
                libro.lib_user_reg = "admin";
                servicioLibro.InsertarLibro(libro);
                return RedirectToAction("Index");
            }

            return View(libro);
        }


        //GET: Edit
        public ActionResult Edit(int? id)
        {
            ViewBag.LibroAlias = new Dictionary<string, string>
            {
                { "lib_id", "Id" },
                { "lib_nom", "Libro" },
                { "aut_id", "Autor" },
                { "gen_id", "Genero" },
                { "lib_edi", "Editorial" },
                { "lib_fec_pub", "Fec Publicacion" },
                { "lib_disp_stock", "Stock" },
                { "edi_id", "Editorial" },
                { "lib_state", "Estado" }
            };
            var libro = servicioLibro.ConsultarLibro((short)id);

            ServicioEditorialClient servicioEditorial = new ServicioEditorialClient();
            ServicioAutorClient servicioAutor = new ServicioAutorClient();
            ServicioGeneroClient servicioGenero = new ServicioGeneroClient();
            var editoriales = servicioEditorial.ObtenerEditoriales();
            var autores = servicioAutor.ObtenerAutores();
            var generos = servicioGenero.ObtenerGeneros();
            ViewBag.aut_id = new SelectList(autores, "AutorId", "AutorNombreApellidos", libro.aut_id);
            ViewBag.edi_id = new SelectList(editoriales, "EditorialId", "EditorialNombre", libro.edi_id);
            ViewBag.gen_id = new SelectList(generos, "GeneroId", "GeneroNombre", libro.gen_id);
            ViewBag.EstadoLibro = ObtenerEstados(libro.lib_state);
            return View(libro);

        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LibroDC libro)
        {
            if (ModelState.IsValid)
            {
                libro.lib_user_mod = "superAdmin";
                libro.lib_fec_mod = DateTime.Now;
                var resultado = servicioLibro.ActualizarLibro(libro);
                if (resultado == true)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "No se pudo actualizar el cliente";
                }
            }

            return View(libro);
        }


        //Obtener Estados para Combo box
        public List<SelectListItem> ObtenerEstados(int Estado)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Inactivo", Value = "0" });
            items.Add(new SelectListItem { Text = "Activo", Value = "1" });

            items[Estado].Selected = true;
            return items;
        }
    }
}