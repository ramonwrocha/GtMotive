using System;
using GtMotive.Estimate.Microservice.Domain.Bases;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents an order in the system.
    /// </summary>
    public sealed class RentalOrderEntity : EntityBase
    {
        /// <summary>
        /// Gets or sets the car associated with the order.
        /// </summary>
        public CarEntity Car { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with the order.
        /// </summary>
        public CustomerEntity Customer { get; set; }

        /// <summary>
        /// Gets or sets the pick-up date for the order.
        /// </summary>
        public DateTime RentalStartDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date for the order.
        /// </summary>
        public DateTime RentalEndDate { get; set; }

        /// <summary>
        /// Gets or sets the total price for the order.
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order has been delivered.
        /// </summary>
        public bool Delivered { get; set; }
    }
}
