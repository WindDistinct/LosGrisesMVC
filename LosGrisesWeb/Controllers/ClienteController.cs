using LosGrisesWeb.ProxyCliente;
using LosGrisesWeb.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LosGrisesWeb.Controllers
{
    public class ClienteController : Controller
    {

        ServicioClienteClient servicioCliente = new ServicioClienteClient();


        // List
        public ActionResult Index()
        {
            
            ViewBag.ClienteAlias = new Dictionary<string, string>
            {
                { "cli_id", "Id" },
                { "cli_nom", "Nombre" },
                { "cli_ape", "Apellido" },
                { "cli_dni", "DNI" },
                { "cli_mail", "Email" },
                { "cli_tel", "Telefono" },
                { "cli_sex", "Sexo" },
                { "cli_dir", "Direccion" }
            };
            var clientes = servicioCliente.ListarCliente();
            return View(clientes);
        }

        //Details
        public ActionResult Details(int id)
        {
            ViewBag.ClienteAlias = new Dictionary<string, string>
            {
                { "cli_id", "Id" },
                { "cli_nom", "Nombre" },
                { "cli_ape", "Apellido" },
                { "cli_dni", "DNI" },
                { "cli_mail", "Email" },
                { "cli_tel", "Telefono" },
                { "cli_sex", "Sexo" },
                { "cli_dir", "Direccion" }
            };
            var cliente = servicioCliente.ConsultarCliente((short)id);
            return View(cliente);
        }

        //GET: Create
        public ActionResult Create()
        {
            ViewBag.ClienteAlias = new Dictionary<string, string>
            {
                { "cli_id", "Id" },
                { "cli_nom", "Nombre" },
                { "cli_ape", "Apellido" },
                { "cli_dni", "DNI" },
                { "cli_mail", "Email" },
                { "cli_tel", "Telefono" },
                { "cli_sex", "Sexo" },
                { "cli_dir", "Direccion" },
                { "cli_fec_nac", "Fec Nacimiento" },
                { "ubg_id", "Ubigeo" }
            };
            ServicioUbigeoClient servicioUbigeo = new ServicioUbigeoClient();
            var ubigeos = servicioUbigeo.ObtenerUbigeos();
            ViewBag.ubgId = new SelectList(ubigeos, "UbigeoId", "UbigeoDesc");
            return View();
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteDC cliente)
        {
            if(ModelState.IsValid)
            {
                cliente.cli_user_reg = "admin";
                servicioCliente.InsertarCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        //GET: Edit
        public ActionResult Edit(int? id)
        {
            ViewBag.ClienteAlias = new Dictionary<string, string>
            {
                { "cli_id", "Id" },
                { "cli_nom", "Nombre" },
                { "cli_ape", "Apellido" },
                { "cli_dni", "DNI" },
                { "cli_mail", "Email" },
                { "cli_tel", "Telefono" },
                { "cli_sex", "Sexo" },
                { "cli_dir", "Direccion" },
                { "cli_fec_nac", "Fec Nacimiento" },
                { "ubg_id", "Ubigeo" },
                { "cli_state", "Estado" }
            };
            var cliente = servicioCliente.ConsultarCliente((short)id);
            
            ServicioUbigeoClient servicioUbigeo = new ServicioUbigeoClient();
            var ubigeos = servicioUbigeo.ObtenerUbigeos();
            ViewBag.ubgId = new SelectList(ubigeos, "UbigeoId", "UbigeoDesc", cliente.ubg_id);
            ViewBag.EstadoCliente = ObtenerEstados(cliente.cli_state);
            return View(cliente);

        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteDC cliente)
        {
            if(ModelState.IsValid)
            {
                cliente.cli_user_mod = "superAdmin";
                cliente.cli_fec_mod = DateTime.Now;
                var resultado = servicioCliente.ActualizarCliente(cliente);
                if(resultado == true)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Error = "No se pudo actualizar el cliente";
                }
            }

            return View(cliente);
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