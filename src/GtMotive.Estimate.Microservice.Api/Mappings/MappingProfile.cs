using AutoMapper;
using GtMotive.Estimate.Microservice.Api.UseCases.AddCar;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddCarInput, CarRequest>().ReverseMap();
        }
    }
}
