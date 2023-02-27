using AlunoFaculdadeCrud.Data.Mappings;
using AlunoFaculdadeCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunoFaculdadeCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<CursoModel> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
        }
    }
}