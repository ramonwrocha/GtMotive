using GtMotive.Estimate.Microservice.Domain.Entities.Base;

namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// Represents a customer entity that inherits from the User class.
    /// </summary>
    public class Customer : UserBase
    {
        /// <summary>
        /// Gets or sets the document number of the customer.
        /// </summary>
        public string DocumentNumber { get; set; }
    }
}
