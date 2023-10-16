using Microsoft.AspNetCore.Mvc;
using teste_pratico_iel.Repository;
using teste_pratico_iel.Models;
using Microsoft.AspNetCore.Http;

namespace teste_pratico_iel.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly LoginRepository _repository;

        public LoginController(ILogger<LoginController> logger, LoginRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]Login login)
        {
            if (ModelState.IsValid)
            {
                if (_repository.IsLogon(login.Username, login.Password))
                {
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Estudantes");
                }
                else
                {
                    ViewBag.Error = "Usuário ou senha incorretas";
                    return View();
                }
            }
            else
            {
                return View();
            }           
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Login login)
        {
            _repository.CadastrarUsuario(login);
            return View("Index");
        }
    }
}
