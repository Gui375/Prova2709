using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.Services;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriancaController : ControllerBase
    {
        private readonly ICriancaServices _criancaService;
        public CriancaController(ICriancaServices criancaService)   
        {
            _criancaService = criancaService;
        }

        [HttpGet]
        public IActionResult ObterCrianca()
        {
            IEnumerable<CriancaViewModel> criancas = _criancaService.ObterTodos();
            return Ok(criancas);
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(NovaCriancaViewModel novaCriancaViewModel)
        {
            _criancaService.Adicionar(novaCriancaViewModel);

            return Ok();
        }
    }
}
