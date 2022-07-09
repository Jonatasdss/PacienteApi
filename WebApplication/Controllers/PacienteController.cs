using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("pacientes")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;
        public PacienteController(IPacienteService pacienteService) => _pacienteService = pacienteService;
        
        
        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            var pacientes = await _pacienteService.ListarTodos();
            
            return Ok(pacientes);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] PacienteDTO paciente)
        {
            await _pacienteService.AdicionarPaciente(paciente);

            return Created("", string.Empty);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPaciente([FromRoute] int id)
        {
            var paciente = await _pacienteService.BuscarPaciente(id);

            return Ok(paciente);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] PacienteDTO paciente)
        {
            await _pacienteService.AtualizarPaciente(paciente);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar([FromRoute] int id)
        {
            await _pacienteService.DeletarPaciente(id);

            return Ok();
        }
    }
}