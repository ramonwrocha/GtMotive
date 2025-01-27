using System;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Entities
{
    public class Car
    {
        public Guid Id { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public bool Available { get; set; }
    }
}
