using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Especialidade
    {
        private Guid _idEspecialidade;
        private string _descricao;
        private Status _statusEspecialidade;

        public Guid IdEspecialidade{
            get{ return IdEspecialidade;}
            set{ _idEspecialidade = value;}
        }
        public string Descricao{
            get{ return Descricao;}
            set{ _descricao = value;}
        }
        public Status StatusEspecialidade{
            get{ return StatusEspecialidade;}
            set {_statusEspecialidade = value;}
        } 
        public Especialidade(Guid id, string descricao, Status statusEsp){
            this.IdEspecialidade = id;
            this.Descricao = descricao;
            this.StatusEspecialidade = statusEsp;
        }  
    }
}