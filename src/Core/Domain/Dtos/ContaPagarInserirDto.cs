using System;
using System.ComponentModel.DataAnnotations;

namespace test_deliverit.src.Core.Domain.Dtos
{
    public class ContaPagarInserirDto
    {
        [Required(ErrorMessage = "Nome Obrigatório.")]
        public string Nome { get; set; }
        public decimal ValorOriginal { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data inválida.")]
        public DateTime DataVencimento { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Data inválida.")]
        public DateTime DataPagamento { get; set; }
    }
}