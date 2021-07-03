using Microsoft.AspNetCore.Mvc;

namespace SOSPet.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Solicitacao()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }

}