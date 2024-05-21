using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class Fidelidade
    {
        private Guid _idFidelidade;
        private Guid _idCliente;
        private int _cortesRealizados;
        private int _cortesGratisDisponiveis;
        private DateTime[] _dataCortesGratis;
    
        [Key]public Guid IdFidelidade{
            get{return _idFidelidade;}
            set{_idFidelidade= value;}
        }
        public Guid IdCliente{
            get{return _idCliente;}
            set{_idCliente= value;}
        }
        public int CortesRealizados{
            get{return _cortesRealizados;}
            set{_cortesRealizados=value;}
        }
        public int CortesGratisDisponiveis{
            get{return _cortesGratisDisponiveis;}
            set{_cortesGratisDisponiveis=value;}
        }
        public DateTime[] DataCortesGratis{
            get{return _dataCortesGratis;}
            set{_dataCortesGratis= value;}
        }

         public Fidelidade(){}
        public Fidelidade(
            Guid id, 
            Guid idCliente, 
            int cortesRealizados, 
            int cortesGratisDisponiveis
            ){
            this.IdFidelidade=id;
            this.IdCliente=idCliente;
            this.CortesRealizados=cortesRealizados;
            this.CortesGratisDisponiveis=cortesGratisDisponiveis;
        }
        public Fidelidade(
            Guid id, 
            Guid idCliente, 
            int cortesRealizados, 
            int cortesGratisDisponiveis, 
            DateTime dataCortegratis){

            this.IdFidelidade=id;
            this.IdCliente=idCliente;
            this.CortesRealizados=cortesRealizados;
            this.CortesGratisDisponiveis=cortesGratisDisponiveis;
            DateTime[] novoArray = new DateTime[DataCortesGratis.Length + 1];
            Array.Copy(DataCortesGratis, novoArray, DataCortesGratis.Length);
            novoArray[DataCortesGratis.Length] = dataCortegratis;
            this.DataCortesGratis = novoArray;

        }
    }
}