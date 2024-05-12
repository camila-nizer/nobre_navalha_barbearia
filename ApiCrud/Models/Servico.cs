using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Servico
    {
        private Guid _idServico;
        private string _nomeServico;
        private Guid _idEspecialidade;
        private Status _statusServico;

        public Guid IdServico{
            get{ return IdServico;}
            set{ _idServico = value; }
        }
        public string NomeServico{
            get{ return NomeServico;}
            set{ _nomeServico = value;}
        }
        public Guid Especialidade{
            get{ return Especialidade;}
            set{ _idEspecialidade=value;}
        }
        public Status StatusServico{
            get{ return StatusServico;}
            set{_statusServico = value;}
        }

        public Servico(Guid id, string nome, Guid especialidade, Status status){
            this.IdServico = id;
            this.NomeServico = nome;
            this.Especialidade = especialidade;
            this.StatusServico = status;
        }
    }
}