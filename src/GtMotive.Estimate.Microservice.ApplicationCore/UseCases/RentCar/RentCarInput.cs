using System;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar
{
    /// <summary>
    /// Represents the input data required to rent a car.
    /// </summary>
    public class RentCarInput : IUseCaseInput
    {
        /// <summary>
        /// Gets or sets the document number of the customer.
        /// </summary>
        public string DocumentNumberCustomer { get; set; }

        /// <summary>
        /// Gets or sets the car license plate.
        /// </summary>
        public string CarLicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the rental start date.
        /// </summary>
        public DateTime RentalStartDate { get; set; }

        /// <summary>
        /// Gets or sets the rental end date.
        /// </summary>
        public DateTime RentalEndDate { get; set; }

        /// <summary>
        /// Gets or sets the total price of the rental.
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
