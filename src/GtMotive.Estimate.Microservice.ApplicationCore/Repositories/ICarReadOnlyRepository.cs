using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repositories
{
    /// <summary>
    /// Interface for read-only operations on Car entities.
    /// </summary>
    public interface ICarReadOnlyRepository
    {
        /// <summary>
        /// Gets a car by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the car.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the car.</returns>
        Task<Car> GetCar(Guid id);

        /// <summary>
        /// Gets all available cars.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of available cars.</returns>
        Task<IEnumerable<Car>> GetAvailableCars();
    }
}
