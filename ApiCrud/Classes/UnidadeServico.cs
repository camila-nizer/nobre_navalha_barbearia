using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class UnidadeServico
    {
        private Guid _idUnidadeServico;
        private Guid _idServico;
        private List<Status> _statusUniSer;
        [Key]public Guid IdUnidadeServico{
            get{ return _idUnidadeServico;}
            set{ _idUnidadeServico = value;}
        }
        public Guid IdServico{
            get{ return _idServico;}
            set{ _idServico = value;}
        }
        public List<Status> StatusUniSer{
            get{ return _statusUniSer;}
            set{ _statusUniSer = value;}
        }

        public UnidadeServico(){}
        public UnidadeServico(Guid id, Guid idServico, List<Status> statusUniSer){
            this.IdUnidadeServico = id;
            this.IdServico = idServico;
            this.StatusUniSer = statusUniSer;
        }
    }
}