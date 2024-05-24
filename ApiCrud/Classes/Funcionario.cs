using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;

namespace ApiCrud.Models
{
    public class Funcionario : Pessoa
    {
        private Guid _idFuncionario;
        private List<Status> _statusFuncionario;

        public Guid IdFuncionario{
            get{ return _idFuncionario;}
            set{ _idFuncionario = value;}
        }
        public List<Status> StatusFuncionario{
            get{ return _statusFuncionario;}
            set{_statusFuncionario = value;}
        }

        public Funcionario(){}
        public Funcionario(
            Guid id, 
            Guid pessoa, 
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
            List<Status> status
            ): base (
                pessoa,
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
            IdFuncionario=id;
            IdPessoa=pessoa;
            StatusFuncionario=status;
        }
    }
}