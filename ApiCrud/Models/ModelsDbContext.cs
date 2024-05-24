using ApiCrud.Classes;
using ApiCrud.Models.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiCrud.Models
{
    public class NobreNavalhaBarbeariaDbContext : DbContext
    {
        public DbSet<Unidades> UnidadesBarbearia { get; set; }
        public DbSet<UnidadeServico> UnidadeServico { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Desconto> Desconto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fidelidade> Fidelidade { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<FuncionarioEspecialidade> FuncionarioEspecialidade { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<PrecoServico> PrecoServico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=4000;Database=meubanco;Username=postgres;Password=camila;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>().HasNoKey();
            modelBuilder.Entity<Endereco>().HasNoKey();
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.IdPessoa);

            modelBuilder.Entity<Pessoa>()
                .Property(p => p.EnderecoPessoa)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Endereco>>(v) ?? new List<Endereco>())
                .Metadata.SetValueComparer(new ValueComparer<List<Endereco>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Pessoa>()
                .Property(p => p.EnderecoPessoa) 
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Endereco>>(v) ?? new List<Endereco>())
                .Metadata.SetValueComparer(new ValueComparer<List<Endereco>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));
            
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.IdPessoa);

            modelBuilder.Entity<Pessoa>()
                .Property(c => c.StatusPessoa)
                .HasColumnName("StatusPessoa")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Cliente>()
                .Property(c => c.IdCliente)
                .ValueGeneratedNever();
            
            modelBuilder.Entity<Cliente>()
                .Property(c => c.StatusPessoa)
                .HasColumnName("StatusPessoa")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v), // Converter a lista de Status para JSON
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Cliente>()
                .Property(c => c.StatusCliente)
                .HasColumnName("StatusCliente")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));
                

            modelBuilder.Entity<Funcionario>()
                .HasBaseType<Pessoa>();

            modelBuilder.Entity<Funcionario>()
                .Property(f => f.IdFuncionario)
                .ValueGeneratedNever();
            
            modelBuilder.Entity<Funcionario>()
                .Property(f => f.StatusPessoa) 
                .HasColumnName("StatusPessoa") 
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Desconto>()
                .Property(c => c.StatusDesconto)
                .HasColumnName("StatusDesconto")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Especialidade>()
                .Property(c => c.StatusEspecialidade)
                .HasColumnName("StatusEspecialidade")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Funcionario>()
                .Property(c => c.StatusFuncionario)
                .HasColumnName("StatusFuncionario")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<FuncionarioEspecialidade>()
                .Property(c => c.StatusFuncEsp)
                .HasColumnName("StatusFuncEsp")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<PrecoServico>()
                .Property(c => c.StatusPrecoServico)
                .HasColumnName("StatusPrecoServico")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Servico>()
                .Property(c => c.StatusServico)
                .HasColumnName("StatusServico")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<UnidadeServico>()
                .Property(c => c.StatusUniSer)
                .HasColumnName("StatusUnidadeServico")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Unidades>()
                .Property(c => c.StatusUni)
                .HasColumnName("StatusUnidade")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));

            modelBuilder.Entity<Atendimento>()
                .Property(a => a.StatusAtendimento)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<Status>>(v) ?? new List<Status>())
                .Metadata.SetValueComparer(new ValueComparer<List<Status>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList()));
        }
    }
}
