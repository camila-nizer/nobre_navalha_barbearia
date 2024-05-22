using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Models
{
    public class Cliente : Pessoa
    {
        private Guid _idCliente;
        private string _observacoes;
        private List<Status> _statusCliente;
        public Guid IdCliente {
            get {return _idCliente;}
            set {_idCliente =value;}
        }
        public string Observacoes{
            get {return _observacoes;}
            set {_observacoes= value;}
        }

        public List<Status> StatusCliente{
            get {return _statusCliente;}
            set {_statusCliente= value;}
        }
        public Cliente():base(){}
        public Cliente(
            Guid id, 
            Guid idpessoa, 
            string nome, 
            DateTime nasc, 
            string cpf, 
            string telefone,
            string email,
            string sexo,
            string tipo,
            List<Status> statusPessoa,
            Guid unidade,
            List<Endereco> endereco,
            string observacoes,
            List<Status> statusCliente
            ): base (
                idpessoa,
                nome,
                nasc,
                cpf,
                telefone,
                email,
                sexo,
                tipo,
                statusPessoa,
                unidade,
                endereco
                ){
            this.IdCliente = id;
            this.Observacoes=observacoes;
            this.StatusCliente = statusCliente;
        }

        public Cliente(
            Guid id, 
            string observacoes,
            List<Status> statusCliente,
            Pessoa pessoa
            ): base (
                pessoa.IdPessoa,
                pessoa.Nome,
                pessoa.Nascimento,
                pessoa.CPF,
                pessoa.Telefone,
                pessoa.Email,
                pessoa.Sexo,
                pessoa.Tipo,
                pessoa.StatusPessoa,
                pessoa.UnidadeBarbearia,
                pessoa.EnderecoPessoa
                ){
            this.IdCliente = id;
            this.Observacoes=observacoes;
            this.StatusCliente = statusCliente;
        }
        public override void ExibeDados(){
        Console.WriteLine("Cliente : ${Nome}. Status: ${StatusCliente}. É um cliente cadastrado no id ${IdCliente}");
        }
    }
        
}