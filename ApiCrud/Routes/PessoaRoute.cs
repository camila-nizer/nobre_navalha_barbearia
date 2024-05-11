using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models;

namespace ApiCrud.Pessoa
{
    public static class PessoaRouter{
        public static void GetPessoa(this WebApplication app){
            app.MapGet("getPessoa" , ()=> new PessoaModel("Camila"));
        }
    }
}