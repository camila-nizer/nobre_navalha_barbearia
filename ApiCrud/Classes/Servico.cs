using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]public Guid IdServico{
            get{ return _idServico;}
            set{ _idServico = value; }
        }
        public string NomeServico{
            get{ return _nomeServico;}
            set{ _nomeServico = value;}
        }
        public Guid Especialidade{
            get{ return _idEspecialidade;}
            set{ _idEspecialidade=value;}
        }
        public Status StatusServico{
            get{ return _statusServico;}
            set{_statusServico = value;}
        }

        public Servico(){}
        public Servico(Guid id, string nome, Guid especialidade, Status status){
            this.IdServico = id;
            this.NomeServico = nome;
            this.Especialidade = especialidade;
            this.StatusServico = status;
        }
    }
}