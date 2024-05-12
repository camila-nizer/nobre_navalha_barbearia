using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Agendamento
    {
        private Guid _idAgendamento;
        private Guid _idCliente;
        private Guid _idServico;
        private Guid _unidadeBarbearia;
        private DateTime _dataHora;
        private Status _statusAgendamento;
        public Guid IdAgendamento{
            get{ return _idAgendamento;}
            set{ _idAgendamento = value;}
        }
            public Guid IdCliente{
            get{ return _idCliente;}
            set{ _idCliente = value;}
        }
        public Guid IdServico{
            get{ return _idServico;}
            set{ _idServico = value;}
        }
        public Guid UnidadeBarbearia{
            get{ return _unidadeBarbearia;}
            set{ _unidadeBarbearia = value;}
        }
        public DateTime DataHora{
            get{ return _dataHora;}
            set{ _dataHora = value;}
        }
        public Status StatusAgendamento{
            get{ return _statusAgendamento;}
            set{ _statusAgendamento = value;}
        }
        public Agendamento(Guid id,Guid cliente, Guid idServico, Guid unidade, DateTime data, Status statusAgendamento){
            this.IdAgendamento = id;
            this.IdCliente = cliente;
            this.IdServico = idServico;
            this.UnidadeBarbearia = unidade;
            this.DataHora = data;
            this.StatusAgendamento= statusAgendamento;
        }
    }
}