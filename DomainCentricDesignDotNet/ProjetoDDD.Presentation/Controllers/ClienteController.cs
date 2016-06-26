using System.Web.Mvc;
using projetoDDD.Application.Interfaces;

namespace ProjetoDDD.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        private IAppClienteService appClienteService;

        public ClienteController(IAppClienteService iAppCliente)
        {
            this.appClienteService = iAppCliente;
        }

        public ActionResult Index()
        {
            appClienteService.DefinirClienteVip();
            return View();
        }

        public ActionResult ObtemTodos()
        {
            return View(appClienteService.ObtemTodos());
        }

        public ActionResult ObtemCliente(int id)
        {
            return View(appClienteService.ObterCliente(id));
        }
    }
}