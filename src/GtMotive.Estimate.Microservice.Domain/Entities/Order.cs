using System;

namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// Represents an order in the system.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the car associated with the order.
        /// </summary>
        public string CarId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the customer associated with the order.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the employer associated with the order.
        /// </summary>
        public string EmployerId { get; set; }

        /// <summary>
        /// Gets or sets the pick-up date for the order.
        /// </summary>
        public DateTime PickUpDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date for the order.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the order was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
