using AlunoFaculdadeCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlunoFaculdadeCrud.Data.Mappings
{
    public class CursoMap : IEntityTypeConfiguration<CursoModel>
    {
        public void Configure(EntityTypeBuilder<CursoModel> builder)
        {
            builder.ToTable("Cursos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NomeCurso")
                .HasColumnType("VARCHAR(100)");
        }
    }
}