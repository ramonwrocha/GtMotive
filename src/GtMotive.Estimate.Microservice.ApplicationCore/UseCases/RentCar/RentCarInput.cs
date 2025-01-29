using System;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar
{
    /// <summary>
    /// Represents the input data required to rent a car.
    /// </summary>
    public class RentCarInput : IUseCaseInput
    {
        /// <summary>
        /// Gets or sets the unique identifier of the car.
        /// </summary>
        public Guid CarId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the customer.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the employer.
        /// </summary>
        public Guid EmployerId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the car will be picked up.
        /// </summary>
        public DateTime PickUpDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the car will be delivered.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the rental record was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
