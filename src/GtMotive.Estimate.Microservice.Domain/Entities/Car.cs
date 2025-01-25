namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// Represents a car entity with an Id, Brand, and Model.
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
    }
}
