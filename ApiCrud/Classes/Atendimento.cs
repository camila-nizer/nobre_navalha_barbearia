using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models;
using System.ComponentModel.DataAnnotations;
using Npgsql;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCrud.Classes
{
    public class Atendimento
    {
        private Guid _idAtendimento;
        private Guid _idCliente;
        private Guid _idServico;
        private Guid _idPrecoServico;
        private Guid _unidadeBarbearia;
         private Guid _idDesconto;
        private DateTime _dataHora;
        private string _observacoes;
        private List<Status> _statusAtendimento;
        private string _tipoPagamento;
        private decimal  _valorPago;
        [Key] public Guid IdAtendimento{
            get{ return _idAtendimento;}
            set{ _idAtendimento = value;}
        }
        public Guid IdCliente{
            get{ return _idCliente;}
            set{ _idCliente = value;}
        }
        public Guid IdServico{
            get{ return _idServico;}
            set{ _idServico = value;}
        }
        public Guid IdPrecoServico{
            get{ return _idPrecoServico;}
            set{ _idPrecoServico = value;}
        }
        public Guid IdDesconto{
            get{ return _idDesconto;}
            set{ _idDesconto = value;}
        }
        public Guid UnidadeBarbearia{
            get{ return _unidadeBarbearia;}
            set{ _unidadeBarbearia = value;}
        }
        public DateTime DataHora{
            get{ return _dataHora;}
            set{ _dataHora = value;}
        }
        public string Observacoes{
            get{ return _observacoes;}
            set{ _observacoes = value;}
        }
        
         public List<Status> StatusAtendimento{
            get{ return _statusAtendimento;}
            set{ _statusAtendimento = value;}
        }
        public string TipoPagamento{
            get{ return _tipoPagamento;}
            set{ _tipoPagamento = value;}
        }
        public decimal ValorPago{
            get{ return _valorPago;}
            set{ _valorPago = value;}
        }
        public Atendimento(){
            // Construtor sem parâmetros para criar classe no bd
        }   
        public Atendimento(
            Guid id,
            Guid cliente, 
            Guid idServico,
            Guid idPrecoServico, 
            Guid unidade, 
            DateTime data, 
            List<Status> statusAtendimento, 
            string observacoes, 
            string tipoPg,
            Guid idDesconto){
            this.IdAtendimento = id;
            this.IdCliente = cliente;
            this.IdServico = idServico;
            this._idPrecoServico= idPrecoServico;
            this.UnidadeBarbearia = unidade;
            this.DataHora = data;
            this.IdDesconto=idDesconto;
            this.StatusAtendimento= statusAtendimento;
            this.Observacoes= observacoes;
            this.TipoPagamento = tipoPg;
            this.ValorPago = CalculaValorPago(idDesconto, idPrecoServico);  

        }
        private decimal CalculaValorPago(Guid? idDesconto, Guid idPrecoServico){
            decimal precoBase = BuscarPrecoServico(idPrecoServico);
            decimal porcentagemDesconto = idDesconto.HasValue ? BuscarValorDesconto(idDesconto.Value) : 0;
            if (porcentagemDesconto==0){
                return precoBase;
            }
            return precoBase * (porcentagemDesconto/100);
        }
       
        private decimal BuscarPrecoServico(Guid idPrecoServico){
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=4000;Database=meubanco;Username=postgres;Password=camila;"))
            {
                conn.Open();
                string queryPreco = "SELECT preco FROM preco_servico WHERE id_preco_servico = @idPrecoServico";
                using (NpgsqlCommand cmdPreco = new NpgsqlCommand(queryPreco, conn))
                {
                    cmdPreco.Parameters.AddWithValue("@idPrecoServico", idPrecoServico);
                    object resultPreco = cmdPreco.ExecuteScalar(); //retorna a primeira linha da primeira coluna somente, ou nulo se o valor não existir
                    if (resultPreco != null && resultPreco != DBNull.Value)
                    {
                        return Convert.ToDecimal(resultPreco);
                    }
                    else
                    {
                        throw new Exception("Preço do serviço não encontrado para o ID especificado.");
                    }
                }
            }
        }
        private decimal BuscarValorDesconto(Guid idDesconto){
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=4000;Database=meubanco;Username=postgres;Password=camila;"))
            {
                conn.Open();
                string queryDesconto = "SELECT valor FROM desconto WHERE id_desconto = @idDesconto";
                using (NpgsqlCommand cmdDesconto = new NpgsqlCommand(queryDesconto, conn))
                {
                    cmdDesconto.Parameters.AddWithValue("@idDesconto", idDesconto);
                    object resultDesconto = cmdDesconto.ExecuteScalar();
                    if (resultDesconto != null && resultDesconto != DBNull.Value)
                    {
                        return Convert.ToDecimal(resultDesconto);
                    }
                    else
                    {
                        throw new Exception("Desconto não encontrado para o ID especificado.");
                    }
                }
            }
        }
    }
}


