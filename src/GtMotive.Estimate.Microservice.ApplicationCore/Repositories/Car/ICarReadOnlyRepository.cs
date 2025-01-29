using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car
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
        Task<Domain.CarEntity> GetCar(Guid id);

        /// <summary>
        /// Gets all available cars.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of available cars.</returns>
        Task<IEnumerable<Domain.CarEntity>> GetAvailableCars();
    }
}
