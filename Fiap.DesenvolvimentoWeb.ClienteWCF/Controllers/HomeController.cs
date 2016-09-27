using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.DesenvolvimentoWeb.ClienteWCF.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var servico = new Srf.Service1Client();
            var lista = servico.ListarFuncionarios();

            return View(lista);
        }
    }
}