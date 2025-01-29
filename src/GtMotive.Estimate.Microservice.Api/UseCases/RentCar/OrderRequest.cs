using System;

namespace GtMotive.Estimate.Microservice.Api.UseCases.RentCar
{
    public class OrderRequest
    {
        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public Guid CustomerId { get; set; }

        public Guid EmployerId { get; set; }

        public DateTime PickUpDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
