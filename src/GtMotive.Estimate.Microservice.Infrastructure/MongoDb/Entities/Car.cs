using System;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Entities
{
    public class Car
    {
        public Guid Id { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int ManufacturingYear { get; set; }

        public bool Available { get; set; }
    }
}
