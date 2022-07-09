using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Interfaces.Repositorios;
using Domain.Interfaces.Servicos;

namespace Domain.Servicos
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        
        public PacienteService(IPacienteRepository pacienteRepository) 
            => _pacienteRepository = pacienteRepository;

        public async Task AdicionarPaciente(PacienteDTO paciente)
            => await _pacienteRepository.AdicionarPaciente(paciente.ToModel());

        public async Task AtualizarPaciente(PacienteDTO paciente)
            => await _pacienteRepository.AtualizarPaciente(paciente.ToModel());

        public async Task DeletarPaciente(int id)
        {
            var paciente = await _pacienteRepository.BuscarPaciente(id);

            await _pacienteRepository.DeletarPaciente(paciente);
        }

        public async Task<IEnumerable<PacienteDTO>> ListarTodos()
        {
            var pacientes = await _pacienteRepository.ListarTodos();

            return pacientes.ToDtoList();
        }

        public async Task<PacienteDTO> BuscarPaciente(int id)
        {
            var paciente = await _pacienteRepository.BuscarPaciente(id);

            return paciente.ToDto();
        }
    }
}