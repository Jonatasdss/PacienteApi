using System.Reflection;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AplicationDbContext:DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> Options):base(Options) 
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
