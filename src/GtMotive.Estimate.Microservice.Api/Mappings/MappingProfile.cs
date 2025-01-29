using System;
using AutoMapper;
using GtMotive.Estimate.Microservice.Api.UseCases.AddCar;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarRequest, AddCarInput>()
            .ForMember(dest => dest.ManufacturingDate, opt => opt.MapFrom(src => src.ManufacturingDate ?? DateTime.MinValue))
            .ForMember(dest => dest.Available, opt => opt.MapFrom(src => src.Available ?? false));
        }
    }
}
