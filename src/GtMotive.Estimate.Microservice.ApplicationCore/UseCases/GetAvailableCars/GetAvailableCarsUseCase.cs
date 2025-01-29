using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.GetAvailableCars
{
    /// <summary>
    /// Use case for getting available cars.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="GetAvailableCarsUseCase"/> class.
    /// </remarks>
    /// <param name="carReadOnlyRepository">The car read-only repository.</param>
    public class GetAvailableCarsUseCase(ICarReadOnlyRepository carReadOnlyRepository) : IGetAvailableCarsUseCase
    {
        private readonly ICarReadOnlyRepository _carReadOnlyRepository = carReadOnlyRepository;

        /// <summary>
        /// Gets the available cars.
        /// </summary>
        /// <returns>A collection of available cars.</returns>
        public async Task<ICollection<GetAvailableCarsOutput>> GetAvailable()
        {
            var result = await _carReadOnlyRepository.GetAvailableCars();

            return result.Select(car => new GetAvailableCarsOutput
            {
                Id = car.Id,
                Available = car.Available,
                Brand = car.Brand,
                LicensePlate = car.LicensePlate,
                ManufacturingYear = car.ManufacturingYear,
                Model = car.Model
            }).ToList();
        }
    }
}
