using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class PessoaModel{
        public Guid Id { get; init; }
        public string Nome {get; set;}
        public bool Ativo {get; set;}

        public PessoaModel(string nome){
            this.Id = Guid.NewGuid();
            this.Ativo= true;
            this.Nome = nome;

        }
    }
}