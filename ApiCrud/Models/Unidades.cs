using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;

namespace ApiCrud.Models
{
    public class Unidades
    {
        private string _nomeSocial;
        private string _cnpj;
        private Endereco _endereco;
        private string _telefone;
        private DateTime _dataAbertura;
        private string _tipo;
        

        public string NomeSocial {
            get {return NomeSocial;}
            set {_nomeSocial = value;}
        }
        public string CNPJ {
            get {return CNPJ;}
            set {_cnpj = value;}
        }
        public Endereco Endereco {
            get {return Endereco;}
            set {_endereco = value;}
        }
        public string Telefone {
            get {return Telefone;}
            set {_telefone = value;}
        }
        public DateTime DataAbertura {
            get {return DataAbertura;}
            set {_dataAbertura = value;}
        }
        public string Tipo {
            get {return Tipo;}
            set {_tipo = value;}
        }
    
        public Unidades(string nomeSocial, string cnpj, Endereco endereco, string telefone, DateTime dataAbertura, string tipo){
            this.NomeSocial = nomeSocial;
            this.CNPJ = cnpj;
            this.Endereco= endereco;
            this.Telefone = telefone;
            this.DataAbertura=dataAbertura;
            this.Tipo=tipo; 
        } 

    }
}