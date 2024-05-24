﻿// <auto-generated />
using System;
using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiCrud.Migrations
{
    [DbContext(typeof(NobreNavalhaBarbeariaDbContext))]
    partial class NobreNavalhaBarbeariaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiCrud.Classes.Atendimento", b =>
                {
                    b.Property<Guid>("IdAtendimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdDesconto")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPrecoServico")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdServico")
                        .HasColumnType("uuid");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusAtendimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TipoPagamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UnidadeBarbearia")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("numeric");

                    b.HasKey("IdAtendimento");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("ApiCrud.Models.Desconto", b =>
                {
                    b.Property<Guid>("IdDesconto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DescricaoDesconto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusDesconto")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusDesconto");

                    b.Property<int>("ValorDesconto")
                        .HasColumnType("integer");

                    b.HasKey("IdDesconto");

                    b.ToTable("Desconto");
                });

            modelBuilder.Entity("ApiCrud.Models.Especialidade", b =>
                {
                    b.Property<Guid>("IdEspecialidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusEspecialidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusEspecialidade");

                    b.HasKey("IdEspecialidade");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("ApiCrud.Models.Fidelidade", b =>
                {
                    b.Property<Guid>("IdFidelidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CortesGratisDisponiveis")
                        .HasColumnType("integer");

                    b.Property<int>("CortesRealizados")
                        .HasColumnType("integer");

                    b.Property<DateTime[]>("DataCortesGratis")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone[]");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.HasKey("IdFidelidade");

                    b.ToTable("Fidelidade");
                });

            modelBuilder.Entity("ApiCrud.Models.FuncionarioEspecialidade", b =>
                {
                    b.Property<Guid>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdEspecialidade")
                        .HasColumnType("uuid");

                    b.Property<string>("StatusFuncEsp")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusFuncEsp");

                    b.HasKey("IdFuncionario");

                    b.ToTable("FuncionarioEspecialidade");
                });

            modelBuilder.Entity("ApiCrud.Models.Pessoa", b =>
                {
                    b.Property<Guid>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EnderecoPessoa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusPessoa")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusPessoa");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UnidadeBarbearia")
                        .HasColumnType("uuid");

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ApiCrud.Models.PrecoServico", b =>
                {
                    b.Property<Guid>("IdPrecoServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("Preco")
                        .HasColumnType("real");

                    b.Property<string>("StatusPrecoServico")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusPrecoServico");

                    b.HasKey("IdPrecoServico");

                    b.ToTable("PrecoServico");
                });

            modelBuilder.Entity("ApiCrud.Models.Servico", b =>
                {
                    b.Property<Guid>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Especialidade")
                        .HasColumnType("uuid");

                    b.Property<string>("NomeServico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusServico")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusServico");

                    b.HasKey("IdServico");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("ApiCrud.Models.Status", b =>
                {
                    b.Property<Guid?>("ClienteIdPessoa")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FuncionarioIdPessoa")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PessoaIdPessoa")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("StatusItem")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasIndex("ClienteIdPessoa");

                    b.HasIndex("FuncionarioIdPessoa");

                    b.HasIndex("PessoaIdPessoa");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ApiCrud.Models.UnidadeServico", b =>
                {
                    b.Property<Guid>("IdUnidadeServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdServico")
                        .HasColumnType("uuid");

                    b.Property<string>("StatusUniSer")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusUnidadeServico");

                    b.HasKey("IdUnidadeServico");

                    b.ToTable("UnidadeServico");
                });

            modelBuilder.Entity("ApiCrud.Models.Unidades", b =>
                {
                    b.Property<Guid>("IdUnidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusUni")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusUnidade");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdUnidade");

                    b.ToTable("UnidadesBarbearia");
                });

            modelBuilder.Entity("ApiCrud.Models.Utils.Endereco", b =>
                {
                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PessoaIdPessoa")
                        .HasColumnType("uuid");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("PessoaIdPessoa");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ApiCrud.Models.Cliente", b =>
                {
                    b.HasBaseType("ApiCrud.Models.Pessoa");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusCliente")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusCliente");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("ApiCrud.Models.Funcionario", b =>
                {
                    b.HasBaseType("ApiCrud.Models.Pessoa");

                    b.Property<Guid>("IdFuncionario")
                        .HasColumnType("uuid");

                    b.Property<string>("StatusFuncionario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("StatusFuncionario");

                    b.HasDiscriminator().HasValue("Funcionario");
                });

            modelBuilder.Entity("ApiCrud.Models.Status", b =>
                {
                    b.HasOne("ApiCrud.Models.Cliente", null)
                        .WithMany()
                        .HasForeignKey("ClienteIdPessoa");

                    b.HasOne("ApiCrud.Models.Funcionario", null)
                        .WithMany()
                        .HasForeignKey("FuncionarioIdPessoa");

                    b.HasOne("ApiCrud.Models.Pessoa", null)
                        .WithMany()
                        .HasForeignKey("PessoaIdPessoa");
                });

            modelBuilder.Entity("ApiCrud.Models.Utils.Endereco", b =>
                {
                    b.HasOne("ApiCrud.Models.Pessoa", null)
                        .WithMany()
                        .HasForeignKey("PessoaIdPessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
