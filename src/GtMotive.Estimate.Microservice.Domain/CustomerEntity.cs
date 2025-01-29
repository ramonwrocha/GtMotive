using GtMotive.Estimate.Microservice.Domain.Bases;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents a customer entity that inherits from the User class.
    /// </summary>
    public sealed class CustomerEntity : EntityBase
    {
        /// <summary>
        /// Gets or sets the document number of the customer.
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the customer.
        /// </summary>
        public string Email { get; set; }
    }
}
