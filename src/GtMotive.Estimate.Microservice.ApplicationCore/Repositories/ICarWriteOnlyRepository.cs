using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repositories
{
    /// <summary>
    /// Interface for write-only repository operations for Car entities.
    /// </summary>
    public interface ICarWriteOnlyRepository
    {
        /// <summary>
        /// Adds a new car to the repository.
        /// </summary>
        /// <param name="car">The car to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task AddCar(Car car);
    }
}
