using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Repositorios;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AplicationDbContext _context;
        private readonly DbSet<Paciente> _paciente;

        public PacienteRepository(AplicationDbContext context)
        {
            _context = context;
            _paciente = _context.Set<Paciente>();
        }

        public async Task AdicionarPaciente(Paciente paciente)
        {
            await _paciente.AddAsync(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarPaciente(Paciente paciente)
        {
            _paciente.Update(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarPaciente(Paciente paciente)
        {
            _paciente.Remove(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Paciente>> ListarTodos()
            => await _paciente.OrderBy(x => x.Id).ToListAsync();

        public async Task<Paciente> BuscarPaciente(int id)
            => await _paciente.FindAsync(id);
    }
}