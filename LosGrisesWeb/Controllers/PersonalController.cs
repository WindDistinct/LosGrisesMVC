using LosGrisesWeb.ProxyPersonal;
using LosGrisesWeb.ProxyUbigeo;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LosGrisesWeb.Controllers
{
    public class PersonalController : Controller
    {
        ServicioPersonalClient servicioPersonal = new ServicioPersonalClient();
        ServicioUbigeoClient servicioUbigeo = new ServicioUbigeoClient();

        // GET: Personal
        public ActionResult Index()
        {
            ViewBag.PersonalAlias = new Dictionary<string, string>
            {
                { "per_id", "Id" },
                { "per_nom", "Nombre" },
                { "per_ape_pat", "Apellido Paterno" },
                { "per_ape_mat", "Apellido Materno" },
                { "per_dni", "DNI" },
                { "per_tel", "Telefono" },
                { "per_mail", "Email" },
                { "per_dir", "Direccion" },
                { "per_state", "Estado" }
            };

            var personal = servicioPersonal.ListarPersonal();
            return View(personal);
        }

        // GET: Personal/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.PersonalAlias = new Dictionary<string, string>
            {
                { "per_id", "Id" },
                { "per_nom", "Nombre" },
                { "per_ape_pat", "Apellido Paterno" },
                { "per_ape_mat", "Apellido Materno" },
                { "per_dni", "DNI" },
                { "per_tel", "Telefono" },
                { "per_mail", "Email" },
                { "per_dir", "Direccion" },
                { "per_state", "Estado" }
            };

            var personal = servicioPersonal.ConsultarPersonal((short)id);
            return View(personal);
        }

        // GET: Personal/Create
        public ActionResult Create()
        {
            ViewBag.PersonalAlias = new Dictionary<string, string>
            {
                { "per_nom", "Nombre" },
                { "per_ape_pat", "Apellido Paterno" },
                { "per_ape_mat", "Apellido Materno" },
                { "per_dni", "DNI" },
                { "per_tel", "Telefono" },
                { "per_mail", "Email" },
                { "per_dir", "Direccion" },
                { "per_pass", "Contraseña" },
                { "per_state", "Estado" },
                { "ubg_id", "Ubigeo" }
            };

            var ubigeos = servicioUbigeo.ObtenerUbigeos();
            ViewBag.ubgId = new SelectList(ubigeos, "UbigeoId", "UbigeoDesc");

            return View();
        }

        // POST: Personal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonalDC personal)
        {
            if (ModelState.IsValid)
            {
                personal.per_user_reg = "admin"; 
                personal.per_fec_reg = DateTime.Now; 
                servicioPersonal.InsertarPersonal(personal);
                return RedirectToAction("Index"); 
            }

            return View(personal); 
        }

        // GET: Personal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var personal = servicioPersonal.ConsultarPersonal((short)id);
            if (personal == null)
            {
                return HttpNotFound();
            }

            ViewBag.PersonalAlias = new Dictionary<string, string>
            {
                { "per_nom", "Nombre" },
                { "per_ape_pat", "Apellido Paterno" },
                { "per_ape_mat", "Apellido Materno" },
                { "per_dni", "DNI" },
                { "per_tel", "Telefono" },
                { "per_mail", "Email" },
                { "per_dir", "Direccion" },
                { "per_state", "Estado" },
                { "ubg_id", "Ubigeo" }
            };

            var ubigeos = servicioUbigeo.ObtenerUbigeos(); 
            ViewBag.ubgId = new SelectList(ubigeos, "UbigeoId", "UbigeoDesc", personal.ubg_id);

            return View(personal);
        }

        // POST: Personal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonalDC personal)
        {
            if (ModelState.IsValid)
            {
                personal.per_user_mod = "admin"; 
                personal.per_fec_mod = DateTime.Now; 
                var resultado = servicioPersonal.ActualizarPersonal(personal); 

                if (resultado)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "No se pudo actualizar el personal.";
                }
            }

            return View(personal);
        }
    }
}
