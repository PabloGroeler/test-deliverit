using System;
using System.Threading.Tasks;
using Moq;
using test_deliverit.src.Core.Domain.Dtos;
using test_deliverit.src.Core.Domain.Entities;
using test_deliverit.src.Core.Domain.Interfaces.Services;
using Xunit;

namespace test_deliverit.test.Services
{
    public class ContaPagarBaseTest
    {
        public static Guid Id;
        public static string Nome;
        public static decimal ValorOriginal;
        public static decimal ValorCorrigido;
        public static DateTime DataVencimento;
        public static DateTime DataPagamento;
        public static int DiasAtraso;
        public static decimal PercentualMulta;
        public static decimal PercentualJuroDia;
        public ContaPagarEntity entity;
        public ContaPagarDto contaPagarDto;
        public ContaPagarInserirDto contaPagarInserirDto;
        public ContaPagarGetDto contaPagarGetDto;
        
        public ContaPagarBaseTest()
        {
            Id = Guid.NewGuid();
            Nome = "Pablo Henrique Groeler";
            ValorOriginal = new decimal(100.0);
            ValorCorrigido = new decimal(0.0);
            DataVencimento = DateTime.Now;
            DataPagamento = DateTime.Now.AddDays(4);
            DiasAtraso = 0;
            PercentualMulta = 0;
            PercentualJuroDia = 0;

            entity = new ContaPagarEntity {
                Id = Id,
                Nome = Nome,
                ValorOriginal = ValorOriginal,
                ValorCorrigido = ValorCorrigido,
                DataVencimento = DataVencimento,
                DataPagamento = DataPagamento,
                DiasAtraso = DiasAtraso,
                PercentualMulta = PercentualMulta,
                PercentualJuroDia = PercentualJuroDia
            };

            contaPagarDto = new ContaPagarDto {
                Id = Id,
                Nome = Nome,
                ValorOriginal = ValorOriginal,
                ValorCorrigido = ValorCorrigido,
                DataVencimento = DataVencimento,
                DataPagamento = DataPagamento,
                DiasAtraso = DiasAtraso,
                PercentualMulta = PercentualMulta,
                PercentualJuroDia = PercentualJuroDia
            };

            contaPagarInserirDto = new ContaPagarInserirDto {
                Nome = Nome,
                ValorOriginal = ValorOriginal,
                DataVencimento = DataVencimento,
                DataPagamento = DataPagamento,
            };

            contaPagarGetDto = new ContaPagarGetDto {
                Nome = Nome,
                ValorOriginal = ValorOriginal,
                ValorCorrigido = ValorCorrigido,
                DiasAtraso = DiasAtraso,
                DataPagamento = DataPagamento,
            };
        }
    }
}