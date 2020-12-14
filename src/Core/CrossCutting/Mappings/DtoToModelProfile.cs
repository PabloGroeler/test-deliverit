using AutoMapper;
using test_deliverit.src.Core.Domain.Dtos;
using test_deliverit.src.Core.Domain.Models;

namespace test_deliverit.src.Core.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region ContaPagar
                CreateMap<ContaPagarModel, ContaPagarDto>().ReverseMap();
                CreateMap<ContaPagarModel, ContaPagarInserirDto>().ReverseMap();
                CreateMap<ContaPagarModel, ContaPagarGetDto>().ReverseMap();
            #endregion
        }
    }
}