namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer
{
    /// <summary>
    /// Input data for adding a customer.
    /// </summary>
    public class AddCustomerInput : IUseCaseInput
    {
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the document number of the customer.
        /// </summary>
        public string DocumentNumber { get; set; }
    }
}
