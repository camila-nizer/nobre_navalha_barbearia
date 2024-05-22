using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Especialidade
    {
        private Guid _idEspecialidade;
        private string _descricao;
        private List<Status> _statusEspecialidade;

        [Key]public Guid IdEspecialidade{
            get{ return _idEspecialidade;}
            set{ _idEspecialidade = value;}
        }
        public string Descricao{
            get{ return _descricao;}
            set{ _descricao = value;}
        }
        public List<Status> StatusEspecialidade{
            get{ return _statusEspecialidade;}
            set {_statusEspecialidade = value;}
        } 

        public Especialidade (){}
        public Especialidade(Guid id, string descricao, List<Status> statusEsp){
            this.IdEspecialidade = id;
            this.Descricao = descricao;
            this.StatusEspecialidade = statusEsp;
        }  
    }
}