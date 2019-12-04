﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191204004308_BancoConfig")]
    partial class BancoConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Sobre");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Domain.Aula", b =>
                {
                    b.Property<int>("IdAula")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Data");

                    b.Property<string>("Local");

                    b.Property<int?>("ProfessorIdProfessor");

                    b.Property<string>("Tipo");

                    b.Property<int>("Vagas");

                    b.HasKey("IdAula");

                    b.HasIndex("ProfessorIdProfessor");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("Domain.Exercicio", b =>
                {
                    b.Property<int>("IdExercicios")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Equipamento");

                    b.Property<int?>("ListaTreinoIdListaTreino");

                    b.Property<int>("Quantidade");

                    b.Property<int>("Repeticoes");

                    b.HasKey("IdExercicios");

                    b.HasIndex("ListaTreinoIdListaTreino");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("Domain.IMCAlunos", b =>
                {
                    b.Property<int>("IMCId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura");

                    b.Property<int?>("AlunoId");

                    b.Property<double>("CalcImc");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<double>("Peso");

                    b.HasKey("IMCId");

                    b.HasIndex("AlunoId");

                    b.ToTable("ImcAlunos");
                });

            modelBuilder.Entity("Domain.ListaTreino", b =>
                {
                    b.Property<int>("IdListaTreino")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("DSemana")
                        .IsRequired();

                    b.Property<string>("NomeLista")
                        .IsRequired();

                    b.HasKey("IdListaTreino");

                    b.ToTable("ListaTreinos");
                });

            modelBuilder.Entity("Domain.Professor", b =>
                {
                    b.Property<int>("IdProfessor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Especialidade");

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("IdProfessor");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Domain.Treino", b =>
                {
                    b.Property<int>("IdTreino")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<int?>("ListaTreinoIdListaTreino");

                    b.Property<string>("Periodo");

                    b.Property<int?>("ProfessorIdProfessor");

                    b.HasKey("IdTreino");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ListaTreinoIdListaTreino");

                    b.HasIndex("ProfessorIdProfessor");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("Domain.Aula", b =>
                {
                    b.HasOne("Domain.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorIdProfessor");
                });

            modelBuilder.Entity("Domain.Exercicio", b =>
                {
                    b.HasOne("Domain.ListaTreino", "ListaTreino")
                        .WithMany()
                        .HasForeignKey("ListaTreinoIdListaTreino");
                });

            modelBuilder.Entity("Domain.IMCAlunos", b =>
                {
                    b.HasOne("Domain.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");
                });

            modelBuilder.Entity("Domain.Treino", b =>
                {
                    b.HasOne("Domain.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("Domain.ListaTreino", "ListaTreino")
                        .WithMany()
                        .HasForeignKey("ListaTreinoIdListaTreino");

                    b.HasOne("Domain.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorIdProfessor");
                });
#pragma warning restore 612, 618
        }
    }
}