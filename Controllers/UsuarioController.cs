using Microsoft.AspNetCore.Mvc;
using SOSPet.Models;

namespace SOSPet.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            
            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastro(UsuarioModel u)
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