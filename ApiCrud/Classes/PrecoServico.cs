using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class PrecoServico
    {
        private Guid _idPrecoServico;
        private float _precoServico;
        private List<Status> _statusServico;

        [Key]public Guid IdPrecoServico{
            get{return _idPrecoServico;}
            set{_idPrecoServico=value;}
        }
        public float Preco{
            get{return _precoServico;}
            set{_precoServico=value;}
        }
        public List<Status> StatusPrecoServico{
            get{return _statusServico;}
            set{_statusServico=value;}
        }

        public PrecoServico(){}
        public PrecoServico(Guid id, float preco, List<Status> statusPreco){
            IdPrecoServico=id;
            Preco=preco;
            StatusPrecoServico=statusPreco;
        }
    }
}