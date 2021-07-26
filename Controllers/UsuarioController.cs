using Microsoft.AspNetCore.Mvc;

namespace SOSPet.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Conta()
        {
            return View();
        }

    }

}