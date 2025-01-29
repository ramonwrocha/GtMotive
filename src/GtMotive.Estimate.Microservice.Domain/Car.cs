using System;
using GtMotive.Estimate.Microservice.Domain.ValueObjects;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents a car entity with an Id, Brand, Model, Year, and Availability.
    /// </summary>
    public sealed class Car
    {
        /// <summary>
        /// Gets or sets the unique identifier for the car.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the license plate of the car.
        /// </summary>
        public LicensePlate LicensePlate { get; set; }

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
        public ManufacturingYear ManufacturingYear { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the available status of the car.
        /// </summary>
        public bool Available { get; set; }
    }
}
