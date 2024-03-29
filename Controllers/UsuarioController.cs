using Microsoft.AspNetCore.Http;
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
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            UsuarioModel usuario = ur.SelectId(u);
            if(usuario != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuario.Id);
                return Redirect("endereco");
            }
            else
            {
                ViewBag.Err = "Algum não está no lugar";
                return View();
            }
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UsuarioModel u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            UsuarioModel usuario = ur.SelectId(u);
            if(usuario != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuario.Id);
                HttpContext.Session.SetString("PrimeiroNome", usuario.PrimeiroNome);
                return Redirect("../");
            }
            else
            {
                ViewBag.ErrLogin = "Não encontrado";
                return View();
            }
            
        }
        public IActionResult Conta()
        {
            return View();
        }

        public IActionResult Endereco()
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return Redirect("login");
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public IActionResult Endereco(EnderecoModel e)
        {
            EnderecoRepository er = new EnderecoRepository();
            if(HttpContext.Session.GetInt32("IdUsuario") != null)
            {
                er.Insert(e, HttpContext.Session.GetInt32("IdUsuario").GetValueOrDefault());
                return Redirect("../");
            }
            else
            {
                ViewBag.Err = "Algum não está no lugar";
                return View();
            }
            
        }

    }

}