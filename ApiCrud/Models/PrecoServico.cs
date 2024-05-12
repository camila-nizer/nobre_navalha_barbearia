using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class PrecoServico
    {
        private Guid _idPrecoServico;
        private float _precoServico;
        private Status _statusServico;

        public Guid IdPrecoServico{
            get{return _idPrecoServico;}
            set{_idPrecoServico=value;}
        }
        public float Preco{
            get{return _precoServico;}
            set{_precoServico=value;}
        }
        public Status StatusServico{
            get{return _statusServico;}
            set{_statusServico=value;}
        }
        public PrecoServico(Guid id, float preco, Status statusPreco){
            IdPrecoServico=id;
            Preco=preco;
            StatusServico=statusPreco;
        }
    }
}