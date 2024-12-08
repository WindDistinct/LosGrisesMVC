using LosGrisesWeb.ProxyLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LosGrisesWeb.Controllers
{
    public class LoginController : Controller
    {

        ServicioLoginClient servicioLogin = new ServicioLoginClient();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            var login = servicioLogin.AutenticarUsuario(username, password);

            if(login == true)
            {
                Session["Username"] = username;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";
                return View();
            }
        }
    }
}