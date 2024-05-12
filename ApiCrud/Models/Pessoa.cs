using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;

namespace ApiCrud.Models
{
    public class Pessoa
    {   
        private Guid _idPessoa;
        private string _nome;
        private DateTime _nascimento;
        private string _cpf;
        private string _telefone;
        private string _email;
        private string _sexo;
        private string _tipo;
        private Status _statusPessoa;
        private Guid _unidadeBarbearia;
        private Endereco _endereco;

        public Guid IdPessoa { 
            get {return _idPessoa;} 
            set{_idPessoa = value;} 
        }
        public string Nome { 
            get {return _nome;} 
            set {_nome = value;} 
        }
        public DateTime Nascimento { 
            get {return _nascimento;} 
            set {_nascimento =value;}
        }
        public string CPF { 
            get {return _cpf;}
            set {_cpf=value;}
        }
        public string Telefone {
            get {return _telefone;}
            set {_telefone=value;}
        }
        public string Email {
            get {return _email;}
            set {_email=value;}
        }
        public string Sexo {
            get {return _sexo;}
            set {_sexo=value;}
        }
        public string Tipo {
            get {return _tipo;}
            set {_tipo=value;}
        }
        public Status StatusPessoa {
            get {return _statusPessoa;}
            set {_statusPessoa=value;}
        }
        public Guid UnidadeBarbearia {
            get {return _unidadeBarbearia;}
            set {_unidadeBarbearia=value;}
        }
        public Endereco EnderecoPessoa {
            get {return _endereco;}
            set {_endereco=value;}
        } 
        
        public Pessoa(Guid id, string nome, DateTime nascimento, string cpf, string telefone, string email, string sexo, string tipo, Status status, Guid unidadeBarbearia, Endereco endereco)
        {
            this.IdPessoa = id;
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Sexo = sexo;
            this.Tipo = tipo;
            this.StatusPessoa = status;
            this.UnidadeBarbearia = unidadeBarbearia;
            this.EnderecoPessoa = endereco;
        }
    }
    

}
