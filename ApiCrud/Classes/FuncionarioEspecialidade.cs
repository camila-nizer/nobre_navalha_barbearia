using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class FuncionarioEspecialidade
    {
        private Guid _idFuncionario;
        private Guid _idEspecialidade;
        private Status _statusFuncEsp;

        [Key]public Guid IdFuncionario{
            get{ return _idFuncionario;}
            set{ _idFuncionario = value;}
        }
        public Guid IdEspecialidade{
            get{return _idEspecialidade;}
            set{_idEspecialidade = value;}
        }
        public Status StatusFuncEsp{
            get{ return _statusFuncEsp;}
            set{_statusFuncEsp = value;}
        }

        public FuncionarioEspecialidade(){}
        public FuncionarioEspecialidade(Guid idFuncionario, Guid idEspecialidade, Status statusFuncEsp){
            this.IdFuncionario = idFuncionario;
            this.IdEspecialidade= idEspecialidade;
            this.StatusFuncEsp= statusFuncEsp;
        }

    }
}