using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interfaces.Repositorios
{
    public interface IPacienteRepository
    {
        Task AdicionarPaciente(Paciente paciente);

        Task AtualizarPaciente(Paciente paciente);

        Task DeletarPaciente(Paciente paciente);

        Task<IEnumerable<Paciente>> ListarTodos();

        Task<Paciente> BuscarPaciente(int id);
    }
}