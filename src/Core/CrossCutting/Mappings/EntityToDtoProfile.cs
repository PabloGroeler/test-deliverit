using AutoMapper;
using test_deliverit.src.Core.Domain.Dtos;
using test_deliverit.src.Core.Domain.Entities;

namespace test_deliverit.src.Core.CrossCutting.Mappings
{
    public class EntityToDtoProfile: Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ContaPagarDto, ContaPagarEntity>().ReverseMap();                
            CreateMap<ContaPagarInserirDto, ContaPagarEntity>().ReverseMap();                
            CreateMap<ContaPagarGetDto, ContaPagarEntity>().ReverseMap();                
        }
    }
}