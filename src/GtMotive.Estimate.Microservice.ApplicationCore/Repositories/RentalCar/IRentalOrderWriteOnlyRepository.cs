using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repositories
{
    /// <summary>
    /// Interface for write-only operations on rental orders.
    /// </summary>
    public interface IRentalOrderWriteOnlyRepository
    {
        /// <summary>
        /// Gets the rental order by customer document number.
        /// </summary>
        /// <param name="documentNumber">The document number of the customer.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the rental order entity.</returns>
        Task<RentalOrderEntity> GetRentalOrderByCustomer(string documentNumber);

        /// <summary>
        /// Adds a new customer to the rental order.
        /// </summary>
        /// <param name="entity">The rental order entity containing customer information.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task RentCar(RentalOrderEntity entity);
    }
}
