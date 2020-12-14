using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using test_deliverit.src.Core.Domain.Dtos;
using test_deliverit.src.Core.Domain.Entities;

namespace test_deliverit.src.Core.Domain.Interfaces.Services
{
    public interface IContaPagarService
    {
        Task<ContaPagarGetDto> Get(Guid id);
        Task<IEnumerable<ContaPagarGetDto>> GetAll();
        Task<ContaPagarDto> Post(ContaPagarInserirDto entity);
        Task<ContaPagarDto> Put(ContaPagarDto entity);
        Task<bool> Delete(Guid id);
    }
}