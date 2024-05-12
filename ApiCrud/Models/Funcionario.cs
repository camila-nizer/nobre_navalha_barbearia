using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Funcionario
    {
        private Guid _idFuncionario;
        private Guid _idPessoa;
        private Status _statusFuncionario;

        public Guid IdFuncionario{
            get{ return _idFuncionario;}
            set{ _idFuncionario = value;}
        }
        public Guid IdPessoa{
            get{ return _idPessoa;}
            set{ _idPessoa = value;}
        }
        public Status StatusFuncionario{
            get{ return _statusFuncionario;}
            set{_statusFuncionario = value;}
        }
        public Funcionario(Guid id, Guid pessoa, Status status){
            IdFuncionario=id;
            IdPessoa=pessoa;
            StatusFuncionario=status;
        }
    }
}