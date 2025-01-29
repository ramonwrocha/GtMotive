using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repositories
{
    /// <summary>
    /// Interface for write-only customer repository.
    /// </summary>
    public interface ICustomerWriteOnlyRepository
    {
        /// <summary>
        /// Adds a new customer to the repository.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task AddCustomer(CustomerEntity customer);

        /// <summary>
        /// Retrieves a customer by their document number.
        /// </summary>
        /// <param name="documentNumber">The document number of the customer.</param>
        /// <returns>A task that represents the asynchronous operation, containing the customer entity.</returns>
        Task<CustomerEntity> GetCustomerByDocumentNumber(string documentNumber);
    }
}
