using AutoMapper;
using test_deliverit.src.Core.Domain.Entities;
using test_deliverit.src.Core.Domain.Models;

namespace test_deliverit.src.Core.CrossCutting.Mappings
{
    public class ModelToEntityProfile: Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<ContaPagarEntity, ContaPagarModel>().ReverseMap();        
        }
    }
}