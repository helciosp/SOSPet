using Microsoft.AspNetCore.Mvc;

namespace SOSPet.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Pre_agendamento()
        {
            return View();
        }
    }

}