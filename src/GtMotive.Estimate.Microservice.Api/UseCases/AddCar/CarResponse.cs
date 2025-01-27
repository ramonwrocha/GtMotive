using System;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public sealed record CarResponse
    {
        public Guid Id { get; set; }
    }
}
