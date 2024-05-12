using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;

namespace ApiCrud.Models
{
    public class Pessoa
    {   
        private Guid _id;
        private string _nome;
        private DateTime _nascimento;
        private string _cpf;
        private string _telefone;
        private string _email;
        private string _sexo;
        private string _tipo;
        private StatusPessoa _statusPessoa;
        private Guid _unidadeBarbearia;
        private Endereco _endereco;

        public Guid Id { 
            get {return Id;} 
            set{_id = value;} 
        }
        public string Nome { 
            get {return Nome;} 
            set {_nome = value;} 
        }
        public DateTime Nascimento { 
            get {return Nascimento;} 
            set {_nascimento =value;}
        }
        public string CPF { 
            get {return CPF;}
            set {_cpf=value;}
        }
        public string Telefone {
            get {return Telefone;}
            set {_telefone=value;}
        }
        public string Email {
            get {return Email;}
            set {_email=value;}
        }
        public string Sexo {
            get {return Sexo;}
            set {_sexo=value;}
        }
        public string Tipo {
            get {return Tipo;}
            set {_tipo=value;}
        }
        public StatusPessoa Status {
            get {return Status;}
            set {_statusPessoa=value;}
        }
        public Guid UnidadeBarbearia {
            get {return UnidadeBarbearia;}
            set {_unidadeBarbearia=value;}
        }
        public Endereco EnderecoPessoa {
            get {return EnderecoPessoa;}
            set {_endereco=value;}
        } 
        
    public Pessoa(Guid id, string nome, DateTime nascimento, string cpf, string telefone, string email, string sexo, string tipo, StatusPessoa status, Guid unidadeBarbearia, Endereco endereco)
    {
        this.Id = id;
        this.Nome = nome;
        this.Nascimento = nascimento;
        this.CPF = cpf;
        this.Telefone = telefone;
        this.Email = email;
        this.Sexo = sexo;
        this.Tipo = tipo;
        this.Status = status;
        this.UnidadeBarbearia = unidadeBarbearia;
        this.EnderecoPessoa = endereco;
    }
    }
    

}
public class StatusPessoa{   
    private Guid _userId;
    private bool _statusPessoa; 

    public Guid UserId {
        get {return _userId;}
        set {_userId=value;}
    }
    public bool Status_Pessoa {
        get {return _statusPessoa;}
        set {Status_Pessoa = value;}
    }

    public StatusPessoa(Guid userId, bool statusPessoa)
    {
        this.UserId = userId;
        this.Status_Pessoa = statusPessoa;
    }
}

