using Microsoft.AspNetCore.Mvc;
using teste_pratico_iel.Models;
using teste_pratico_iel.Repository;


namespace teste_pratico_iel.Controllers
{
    public class EstudanteController : Controller
    {
        private readonly ILogger<EstudanteRepository> _logger;
        private readonly EstudanteRepository _studanteRepository;

        public EstudanteController(ILogger<EstudanteRepository> logger, EstudanteRepository studanteRepository)
        {
            _logger = logger;
            _studanteRepository = studanteRepository;
        }

        public IActionResult Index(int? page)
        {
            return View(_studanteRepository.ListarEstudantes());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Estados = _studanteRepository.ListarEstados();
            ViewBag.Cidades = _studanteRepository.ListarCidades();
            ViewBag.Instituicoes = _studanteRepository.ListarInstituicoes();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Estudante estudante)
        {
            _studanteRepository.CadastrarEstudante(estudante);
            return View("Index", _studanteRepository.ListarEstudantes());
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _studanteRepository.RemoverEsudante(id);

            return View("Index");
        }
    }
}
