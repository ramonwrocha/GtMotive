﻿namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// Represents a car entity with an Id, Brand, Model, Year, and Availability.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the unique identifier for the car.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the brand of the car.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year of the car.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the available status of the car.
        /// </summary>
        public bool Available { get; set; }
    }
}
