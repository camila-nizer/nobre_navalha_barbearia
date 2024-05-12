using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class UnidadeServico
    {
        private Guid _idUnidade;
        private Guid _idServico;
        private Status _statusUniSer;
        public Guid IdUnidade{
            get{ return _idUnidade;}
            set{ _idUnidade = value;}
        }
        public Guid IdServico{
            get{ return _idServico;}
            set{ _idServico = value;}
        }
        public Status StatusUniSer{
            get{ return _statusUniSer;}
            set{ _statusUniSer = value;}
        }
        public UnidadeServico(Guid id, Guid idServico, Status statusUniSer){
            this.IdUnidade = id;
            this.IdServico = idServico;
            this.StatusUniSer = statusUniSer;
        }
    }
}