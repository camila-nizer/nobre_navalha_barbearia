using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models.Utils;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Models
{
    public class Unidades
    {
        private Guid _idUnidade;
        private string _nomeSocial;
        private string _cnpj;
        private Endereco _endereco;
        private string _telefone;
        private DateTime _dataAbertura;
        private string _tipo;
        
        private Status _statusUni;

        [Key]public Guid IdUnidade {
            get {return _idUnidade;}
            set {_idUnidade = value;}
        }
        public string NomeSocial {
            get {return _nomeSocial;}
            set {_nomeSocial = value;}
        }
        public string CNPJ {
            get {return _cnpj;}
            set {_cnpj = value;}
        }
        public Endereco Endereco {
            get {return _endereco;}
            set {_endereco = value;}
        }
        public string Telefone {
            get {return _telefone;}
            set {_telefone = value;}
        }
        public DateTime DataAbertura {
            get {return _dataAbertura;}
            set {_dataAbertura = value;}
        }
        public string Tipo {
            get {return _tipo;}
            set {_tipo = value;}
        }
        public Status StatusUni {
            get {return _statusUni;}
            set {_statusUni = value;}
        }

        public Unidades(){}
        public Unidades(Guid id, string nomeSocial, string cnpj, Endereco endereco, string telefone, DateTime dataAbertura, string tipo, Status statusUni) {
            this.IdUnidade=id;
            this.NomeSocial = nomeSocial;
            this.CNPJ = cnpj;
            this.Endereco= endereco;
            this.Telefone = telefone;
            this.DataAbertura=dataAbertura;
            this.Tipo=tipo;
            this.StatusUni= statusUni; 
        } 

    }
    
}