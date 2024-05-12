using System;
using System.Collections.Generic;
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
        public string Rua {
            get { return Rua; }
            set { _rua = value; }
        }
        public string Numero {
            get { return Numero; }
            set { _numero = value; }
        }
        public string Complemento {
            get { return Complemento; }
            set { _complemento = value; }
        }
        public string Bairro {
            get { return Bairro; }
            set { _bairro = value; }
        }
        public string Cidade {
            get { return Cidade; }
            set { _cidade = value; }
        }
        public string Estado {
            get { return Estado; }
            set { _estado = value; }
        }
        public string CEP {
            get { return CEP; }
            set { _cep = value; }
        }

        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, string cep){
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CEP = cep;
        }
    }
}