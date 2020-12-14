using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using test_deliverit.Core.Domain.Entities;

namespace test_deliverit.Core.Domain.Interfaces.Services
{
    public interface IContaPagarService
    {
        Task<ContaPagarEntity> Get(Guid id);
        Task<IEnumerable<ContaPagarEntity>> GetAll();
        Task<ContaPagarEntity> Post(ContaPagarEntity entity);
        Task<ContaPagarEntity> Put(ContaPagarEntity entity);
        Task<bool> Delete(Guid id);
    }
}