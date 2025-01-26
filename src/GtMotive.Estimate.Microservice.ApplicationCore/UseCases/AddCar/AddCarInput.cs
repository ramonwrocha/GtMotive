using System;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar
{
    /// <summary>
    /// Represents the input data required to add a car.
    /// </summary>
    public class AddCarInput : IUseCaseInput
    {
        /// <summary>
        /// Gets or sets the license plate of the car.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the brand of the car.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the manufacturing date of the car.
        /// </summary>
        public DateTime ManufacturingDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the car is available.
        /// </summary>
        public bool Available { get; set; }
    }
}
