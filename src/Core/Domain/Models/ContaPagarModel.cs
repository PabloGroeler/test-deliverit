using System;

namespace test_deliverit.src.Core.Domain.Models
{
    public class ContaPagarModel: BaseModel
    {
        public string Nome { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorCorrigido { get; set; }        
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int DiasAtraso { get; set; }
        public decimal PercentualMulta { get; set; }
        public decimal PercentualJuroDia { get; set; }  
    }
}