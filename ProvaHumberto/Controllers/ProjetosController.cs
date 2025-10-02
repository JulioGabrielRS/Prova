using Microsoft.AspNetCore.Mvc;
using ProvaHumberto.Models;
using ProvaHumberto.Repositories;



namespace ProvaHumberto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetosController(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpPost]
        public IActionResult CadastrarProjeto([FromBody] Projeto projeto)
        {   
            if (string.IsNullOrWhiteSpace(projeto.NomeProjeto) || projeto.NomeProjeto.Length < 3 || projeto.NomeProjeto.Length > 50)
                return BadRequest("Nome do projeto deve ter entre 3 e 50 caracteres.");

            if (!ValidarEmail(projeto.Email))
                return BadRequest("Email inválido.");

            if (projeto.Turma < 1 || projeto.Turma > 8)
                return BadRequest("Turma deve ser um número entre 1 e 8.");

            if (string.IsNullOrWhiteSpace(projeto.Descricao) || projeto.Descricao.Length > 500)
                return BadRequest("Descrição deve ter no máximo 500 caracteres.");

            if (projeto.NroProjeto < 10 || projeto.NroProjeto > 99)
                return BadRequest("Número do projeto deve ser entre 10 e 99.");

           
            if (_projetoRepository.GetAllProjetos().Any(p => p.NroProjeto == projeto.NroProjeto))
                return BadRequest("Já existe um projeto com o mesmo número.");

           
            _projetoRepository.AddProjeto(projeto);

            return CreatedAtAction(nameof(CadastrarProjeto), projeto);
        }

        private bool ValidarEmail(string email)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Projeto>> GetProjetos()
        {
            var projetos = _projetoRepository.GetAllProjetos();
            return Ok(projetos);
        }

        [HttpPost("visitas")]
       
    }
}