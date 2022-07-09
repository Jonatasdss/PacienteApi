using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Interfaces.Servicos
{
    public interface IPacienteService
    {
        Task AdicionarPaciente(PacienteDTO paciente);

        Task AtualizarPaciente(PacienteDTO paciente);

        Task DeletarPaciente(int id);

        Task<IEnumerable<PacienteDTO>> ListarTodos();

        Task<PacienteDTO> BuscarPaciente(int id);
    }
}