using System;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public record CarRequest
    {
        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public bool Available { get; set; }
    }
}
