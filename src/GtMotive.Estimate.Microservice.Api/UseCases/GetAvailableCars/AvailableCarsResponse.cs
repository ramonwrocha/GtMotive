namespace GtMotive.Estimate.Microservice.Api.UseCases.GetAvailableCars
{
    public class AvailableCarsResponse
    {
        public int Id { get; set; }

        public bool Available { get; set; }

        public string Brand { get; set; }

        public string LicensePlate { get; set; }

        public int ManufacturingYear { get; set; }

        public string Model { get; set; }
    }
}
