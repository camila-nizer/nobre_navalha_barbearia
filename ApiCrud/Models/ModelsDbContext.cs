using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Classes;
using ApiCrud.Models.Utils;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Models
{
    public class UnidadeBarbeariaDbContext: DbContext
    {
    public DbSet<Unidades> UnidadesBarbearia { get; set; }
    public DbSet<UnidadeServico> UnidadeServico {get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Desconto> Desconto { get; set; }
    public DbSet<Cliente> Cliente {get; set; }
    public DbSet<Fidelidade> Fidelidade {get; set; }
    public DbSet<Atendimento> Atendimento {get; set; }
    public DbSet<Funcionario> Funcionario {get; set; }
    public DbSet<Especialidade> Especialidade {get; set; }
    public DbSet<FuncionarioEspecialidade> FuncionarioEspecialidade {get; set; }
    public DbSet<Servico> Servico {get; set; }
    public DbSet<PrecoServico> PrecoServico {get; set; }
    
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=meubanco;Username=postgres;Password=camila;");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.IdPessoa);
            
            modelBuilder.Entity<Pessoa>()
                .Property(c => c.StatusPessoa)
                .HasColumnName("StatusPessoa")
                .HasConversion(
                    v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                    v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
                );
                
            modelBuilder.Entity<Cliente>()
                .HasBaseType<Pessoa>();

            modelBuilder.Entity<Atendimento>()
                .Property(a => a.StatusAtendimento)
                .HasColumnName("StatusAtendimento")
                .HasConversion(
                    v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                    v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
                );
            modelBuilder.Entity<Cliente>()
                .Property(c => c.IdCliente)
                .ValueGeneratedNever();

            modelBuilder.Entity<Cliente>()
                .Property(c => c.StatusCliente)
                .HasColumnName("StatusCliente") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );

            modelBuilder.Entity<Funcionario>()
                .HasBaseType<Pessoa>();

            modelBuilder.Entity<Funcionario>()
                .Property(f => f.IdFuncionario)
                .ValueGeneratedNever();

            modelBuilder.Entity<Status>()
                .HasNoKey();
            modelBuilder.Entity<Endereco>()
                .HasNoKey();
            modelBuilder.Entity<Desconto>()
                .Property(c => c.StatusDesconto)
                .HasColumnName("StatusDesconto") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );    

            modelBuilder.Entity<Especialidade>()
                .Property(c => c.StatusEspecialidade)
                .HasColumnName("StatusEspecialidade") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );  
            modelBuilder.Entity<Funcionario>()
                .Property(c => c.StatusFuncionario)
                .HasColumnName("StatusFuncionario") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );    
            modelBuilder.Entity<FuncionarioEspecialidade>()
                .Property(c => c.StatusFuncEsp)
                .HasColumnName("StatusFuncEsp") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );  
            modelBuilder.Entity<PrecoServico>()
                .Property(c => c.StatusPrecoServico)
                .HasColumnName("StatusPrecoServico") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );   
            modelBuilder.Entity<Servico>()
                .Property(c => c.StatusServico)
                .HasColumnName("StatusServico") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );   
            modelBuilder.Entity<UnidadeServico>()
                .Property(c => c.StatusUniSer)
                .HasColumnName("StatusUnidadeServico") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );   
            modelBuilder.Entity<Unidades>()
                .Property(c => c.StatusUni)
                .HasColumnName("StatusUnidade") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            );
            modelBuilder.Entity<Endereco>()
                .Property(c => c.StatusEndereco)
                .HasColumnName("StatusUnidade") // Define o nome da coluna no banco de dados
                .HasConversion(
                v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                v => Newtonsoft.Json.JsonConvert.DeserializeObject<Status>(v)
            ); 
    }


    }
}