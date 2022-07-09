using System.Collections.Generic;
using System.Linq;
using Domain.DTO;
using Domain.Model;

namespace Domain.Servicos
{
    public static class Utilidade
    {
        public static PacienteDTO ToDto(this Paciente paciente) =>
            new PacienteDTO(
                paciente.Id, 
                paciente.Nome, 
                paciente.Idade, 
                paciente.Sintoma, 
                paciente.Email,
                paciente.Plano);

        public static Paciente ToModel(this PacienteDTO paciente) =>
            new Paciente(
                paciente.Id, 
                paciente.Nome, 
                paciente.Idade,
                paciente.Sintoma,
                paciente.Email,
                paciente.Plano);

        public static IEnumerable<PacienteDTO> ToDtoList(this IEnumerable<Paciente> list) 
            => list.Select(item => item.ToDto()).ToList();
    }
}