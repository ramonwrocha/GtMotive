namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public class CarRequest
    {
        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int? ManufacturingYear { get; set; }

        public bool? Available { get; set; }
    }
}
