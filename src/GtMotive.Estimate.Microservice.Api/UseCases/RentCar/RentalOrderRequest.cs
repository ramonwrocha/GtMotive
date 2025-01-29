using System;

namespace GtMotive.Estimate.Microservice.Api.UseCases.RentCar
{
    public class RentalOrderRequest
    {
        public string DocumentNumberCustomer { get; set; }

        public string CarLicensePlate { get; set; }

        public DateTime? RentalStartDate { get; set; }

        public DateTime? RentalEndDate { get; set; }
    }
}
