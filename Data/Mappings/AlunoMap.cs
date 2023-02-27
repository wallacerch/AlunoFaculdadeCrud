using AlunoFaculdadeCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlunoFaculdadeCrud.Data.Mappings
{
    public class AlunoMap : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NomeAluno")
                .HasColumnType("VARCHAR(255)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("EmailAluno")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnName("CpfAluno")
                .HasColumnType("VARCHAR(11)");

            builder.Property(x => x.Matricula)
                .IsRequired()
                .HasColumnName("MatriculaAluno")
                .HasColumnType("VARCHAR(10)");

            builder.HasOne(x => x.Curso);

            builder.Property(x => x.Turno)
                .IsRequired()
                .HasColumnName("TurnoAluno")
                .HasColumnType("CHARACTER(5)");
        }
    }
}