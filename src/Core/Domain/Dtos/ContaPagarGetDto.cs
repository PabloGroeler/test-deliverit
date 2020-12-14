using System;

namespace test_deliverit.src.Core.Domain.Dtos
{
    public class ContaPagarGetDto
    {
        public string Nome { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorCorrigido { get; set; }
        public int DiasAtraso { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}