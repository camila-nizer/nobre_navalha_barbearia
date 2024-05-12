using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Desconto
    {
        private Guid id_desconto;
        private string _descricaoDesconto;
        private Status _statusDesconto;

        public Guid IdDesconto{
            get{ return id_desconto;}
            set{ id_desconto = value;}
        }
        public string DescricaoDesconto{
            get{ return _descricaoDesconto;}
            set {_descricaoDesconto = value;}
        }
        public Status StatusDesconto{
            get{ return _statusDesconto;}
            set {_statusDesconto = value;}
        }
        public Desconto(Guid id, string descricaoDesconto, Status statusDesconto){
            this.IdDesconto=id;
            this.DescricaoDesconto=descricaoDesconto;
            this.StatusDesconto=statusDesconto;
        }

    }
}