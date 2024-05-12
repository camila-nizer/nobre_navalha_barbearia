using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Cliente
    {
        private Guid _idCliente;
        private Guid _idPessoa;
        private string _observacoes;
        private Status _statusCliente;
        public Guid IdCliente {
            get {return _idCliente;}
            set {_idCliente =value;}
        }
        public Guid IdPessoa {
            get {return _idPessoa;}
            set {_idPessoa=value;}
        }
        public string Observacoes{
            get {return _observacoes;}
            set {_observacoes= value;}
        }

        public Status StatusCliente{
            get {return _statusCliente;}
            set {_statusCliente= value;}
        }
        public Cliente(Guid id,Guid pessoa, string observacoes, Status statusCliente){
            this.IdCliente = id;
            this.IdPessoa = pessoa;
            this.Observacoes=observacoes;
            this.StatusCliente = statusCliente;
        }
    }
        
}