using System.Reflection.Metadata;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using test_deliverit.src.Core.Domain.Interfaces.Services;
using test_deliverit.src.Core.Domain.Entities;
using test_deliverit.src.Core.Domain.Interfaces.Repository;
using test_deliverit.src.Core.Domain.Dtos;
using AutoMapper;
using test_deliverit.src.Core.Domain.Models;

namespace test_deliverit.src.Core.Services
{
    public class ContaPagarService : IContaPagarService
    {
        private IContaPagarRepository _repository;
        private readonly IMapper _mapper;

        public ContaPagarService(IContaPagarRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ContaPagarGetDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ContaPagarGetDto>(entity);
        }
        public async Task<IEnumerable<ContaPagarGetDto>> GetAll()
        {
            var entity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ContaPagarGetDto>>(entity);
        }

        public async Task<ContaPagarDto> Post(ContaPagarInserirDto contaPagar)
        {
            var model = _mapper.Map<ContaPagarModel>(contaPagar);
            var entity = _mapper.Map<ContaPagarEntity>(model);
            ProcessarMultaJuros(entity);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ContaPagarDto>(result);
        }

        public async Task<ContaPagarDto> Put(ContaPagarDto contaPagar)
        {
            var model = _mapper.Map<ContaPagarModel>(contaPagar);
            var entity = _mapper.Map<ContaPagarEntity>(model);
            ProcessarMultaJuros(entity);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ContaPagarDto>(result);
        }

        private void CalcularMulta(ContaPagarEntity entity)
        {
            entity.ValorCorrigido = entity.ValorOriginal * (entity.PercentualMulta / 100);
        }

        private void CalcularJuros(ContaPagarEntity entity)
        {
            entity.ValorCorrigido = entity.ValorOriginal + ( entity.ValorOriginal * entity.PercentualJuroDia * entity.DiasAtraso);
        }

        public void ProcessarMultaJuros(ContaPagarEntity entity) {
            entity.DiasAtraso = entity.DataPagamento.Day - entity.DataVencimento.Day;
            if (entity.DiasAtraso <= 3) {
                entity.PercentualMulta = 2;
                entity.PercentualJuroDia = new decimal(0.1);   
                CalcularMulta(entity);
                CalcularJuros(entity);
            } 
            else if (entity.DiasAtraso > 3 && entity.DiasAtraso <=5) {
                entity.PercentualMulta = 3;
                entity.PercentualJuroDia = new decimal(0.2);                                
                CalcularMulta(entity);
                CalcularJuros(entity);
            } else if (entity.DiasAtraso > 5) {
                entity.PercentualMulta = 5;
                entity.PercentualJuroDia = new decimal(0.3);                                
                CalcularMulta(entity);
                CalcularJuros(entity);
            }
        }
    }
}