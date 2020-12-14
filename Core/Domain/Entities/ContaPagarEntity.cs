using System;
using System.ComponentModel.DataAnnotations;

namespace test_deliverit.Core.Domain.Entities
{
    public class ContaPagarEntity : BaseEntity
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal ValorOriginal { get; set; }
        [Required]
        public decimal ValorCorrigido { get; set; }
        [Required]
        public DateTime DataVencimento { get; set; }
        [Required]
        public DateTime DataPagamento { get; set; }
        [Required]
        public int DiasAtraso { get; set; }
        [Required]
        public decimal PercentualMulta { get; set; }
        [Required]
        public decimal PercentualJuroDia { get; set; }

    }
}