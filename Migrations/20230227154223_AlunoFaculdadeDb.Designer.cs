﻿// <auto-generated />
using AlunoFaculdadeCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AlunoFaculdadeCrud.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230227154223_AlunoFaculdadeDb")]
    partial class AlunoFaculdadeDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AlunoFaculdadeCrud.Models.AlunoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("CpfAluno");

                    b.Property<int>("CursoId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("EmailAluno");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("MatriculaAluno");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("NomeAluno");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("CHARACTER(5)")
                        .HasColumnName("TurnoAluno");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("AlunoFaculdadeCrud.Models.CursoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NomeCurso");

                    b.HasKey("Id");

                    b.ToTable("Cursos", (string)null);
                });

            modelBuilder.Entity("AlunoFaculdadeCrud.Models.AlunoModel", b =>
                {
                    b.HasOne("AlunoFaculdadeCrud.Models.CursoModel", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}
