using System.Collections.Generic;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.GetAvailableCars
{
    /// <summary>
    /// Interface for the use case to get available cars.
    /// </summary>
    public interface IGetAvailableCarsUseCase
    {
        /// <summary>
        /// Gets the available cars.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of available cars.</returns>
        public Task<ICollection<GetAvailableCarsOutput>> GetAvailable();
    }
}
