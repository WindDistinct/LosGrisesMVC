using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using LosGrisesWeb.ProxyConsultas;

namespace LosGrisesWeb.Controllers
{
    public class ConsultaController : Controller
    {
        ServicioConsultasClient consultasClient = new ServicioConsultasClient();
        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LibrosAlquilados()
        {
            ViewBag.ObtenerLibrosMasAlquilados = consultasClient.ObtenerLibrosMasAlquilados(DateTime.Now.AddYears(-1),DateTime.Now,null);
            return View();
        }

        public ActionResult FiltrarLibrosAlquilados(FormCollection fc)
        {
            String fechaInicio = fc["FechaInicio"];
            String fechaFin = fc["FechaFin"];
            String libro = fc["Libro"];
            ViewBag.ObtenerLibrosMasAlquilados = consultasClient.ObtenerLibrosMasAlquilados(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFin), libro);

            return View("LibrosAlquilados");
        }

        public ActionResult GenerosSolicitados()
        {
            ViewBag.ObtenerGenerosMasSolicitados = consultasClient.ObtenerGenerosMasSolicitados().OrderByDescending(genero => genero.VecesSolicitado);
            return View();
        }

        public ActionResult EditorialesAlquiladas()
        {
            ViewBag.EditorialesMasAlquiladas = consultasClient.ObtenerEditorialesMasAlquiladas(DateTime.Now.AddYears(-1), DateTime.Now).OrderByDescending(cantidad => cantidad.VecesAlquilada);
            return View();
        }

        public ActionResult EditorialesXRentas(FormCollection fc)
        {
            String fechaInicio = fc["FechaInicio"];
            String fechaFin = fc["FechaFin"];

            ViewBag.EditorialesMasAlquiladas = consultasClient.ObtenerEditorialesMasAlquiladas(Convert.ToDateTime(fechaInicio),Convert.ToDateTime(fechaFin)).OrderByDescending(cantidad => cantidad.VecesAlquilada);

            return View("EditorialesAlquiladas");
        }

        public ActionResult EjemplaresDisponibles()
        {
            ViewBag.EjemplaresDisponibles = consultasClient.ConsultarEjemplaresDisponibles(null).OrderBy(ejem => ejem.Disponibilidad);
            return View();
        }
        public ActionResult BuscarLibro(FormCollection fc)
        {
            String libro = fc["Libro"];

            ViewBag.EjemplaresDisponibles = consultasClient.ConsultarEjemplaresDisponibles(libro);

            return View("EjemplaresDisponibles");
        }

        public ActionResult RentasXFechas()
        {
            ViewBag.RentasXFechas = consultasClient.ObtenerRentasPorFechas(DateTime.Now.AddYears(-1), DateTime.Now, null).OrderBy(fecha => fecha.rent_fec);
            return View();
        }
        public ActionResult FiltrarRentas(FormCollection fc)
        {
            String fechaInicio = fc["FechaInicio"];
            String fechaFin = fc["FechaFin"];
            String cliente = fc["Cliente"];
            ViewBag.RentasXFechas = consultasClient.ObtenerRentasPorFechas(Convert.ToDateTime(fechaInicio),Convert.ToDateTime(fechaFin),cliente).OrderBy(fecha => fecha.rent_fec);

            return View("RentasXFechas");
        }
    }
}