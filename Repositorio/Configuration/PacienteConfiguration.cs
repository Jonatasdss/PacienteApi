using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Idade).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Sintoma).IsRequired();
            builder.Property(x => x.Email).IsRequired();
        }
    }
}