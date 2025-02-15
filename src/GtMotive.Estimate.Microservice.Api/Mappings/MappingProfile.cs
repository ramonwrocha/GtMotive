﻿using AutoMapper;
using GtMotive.Estimate.Microservice.Api.UseCases.AddCar;
using GtMotive.Estimate.Microservice.Api.UseCases.GetAvailableCars;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarRequest, AddCarInput>()
            .ForMember(dest => dest.ManufacturingYear, opt => opt.MapFrom(src => src.ManufacturingYear ?? 0))
            .ForMember(dest => dest.Available, opt => opt.MapFrom(src => src.Available ?? false));

            CreateMap<CustomerRequest, AddCustomerInput>();

            CreateMap<GetAvailableCarsOutput, AvailableCarsResponse>();
        }
    }
}
