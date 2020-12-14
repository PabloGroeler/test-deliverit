using System.Reflection.Metadata;
using System;
using System.Threading.Tasks;
using test_deliverit.Core.Domain.Entities;
using test_deliverit.Core.Domain.Interfaces.Repository;
using test_deliverit.Core.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace test_deliverit.Core.Services
{
    public class ContaPagarService : IContaPagarService
    {
        private IContaPagarRepository _repository;

        public ContaPagarService(IContaPagarRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ContaPagarEntity> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return entity;
        }
        public async Task<IEnumerable<ContaPagarEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ContaPagarEntity> Post(ContaPagarEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<ContaPagarEntity> Put(ContaPagarEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}