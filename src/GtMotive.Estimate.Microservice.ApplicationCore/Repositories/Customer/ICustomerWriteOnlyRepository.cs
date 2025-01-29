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
    }
}
