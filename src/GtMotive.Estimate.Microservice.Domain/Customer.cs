using GtMotive.Estimate.Microservice.Domain.Base;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents a customer entity that inherits from the User class.
    /// </summary>
    public sealed class Customer : UserBase
    {
        /// <summary>
        /// Gets or sets the document number of the customer.
        /// </summary>
        public string DocumentNumber { get; set; }
    }
}
