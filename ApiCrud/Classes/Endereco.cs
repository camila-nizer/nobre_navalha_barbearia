using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models.Utils
{
    public class Endereco
    {
        private string _rua;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _cep;
        private List<Status> _statusEndereco;
        public string Rua {
            get { return _rua; }
            set { _rua = value; }
        }
        public string Numero {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Complemento {
            get { return _complemento; }
            set { _complemento = value; }
        }
        public string Bairro {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string Cidade {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Estado {
            get { return _estado; }
            set { _estado = value; }
        }
        public string CEP {
            get { return _cep; }
            set { _cep = value; }
        }
        [NotMapped] public List<Status> StatusEndereco {
            get { return _statusEndereco; }
            set { _statusEndereco = value; }
        }

        public Endereco(){}
        public Endereco(
            string rua, 
            string numero, 
            string complemento, 
            string bairro, 
            string cidade, 
            string estado, 
            string cep, 
            List<Status> statusEnd
            ){
                
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CEP = cep;
            this.StatusEndereco = statusEnd;
        }
    }
}