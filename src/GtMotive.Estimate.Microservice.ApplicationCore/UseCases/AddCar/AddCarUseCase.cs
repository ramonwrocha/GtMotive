using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car;
using GtMotive.Estimate.Microservice.Domain.ValueObjects;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar
{
    /// <summary>
    /// Use case for adding a car.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="AddCarUseCase"/> class.
    /// </remarks>
    /// <param name="carWriteOnlyRepository">The car write-only repository.</param>
    public class AddCarUseCase(ICarWriteOnlyRepository carWriteOnlyRepository) : IAddCarUseCase
    {
        private readonly ICarWriteOnlyRepository _carWriteOnlyRepository = carWriteOnlyRepository;

        /// <summary>
        /// Executes the use case with the specified input.
        /// </summary>
        /// <param name="input">The input for the use case.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task Execute(AddCarInput input)
        {
            ArgumentNullException.ThrowIfNull(input);

            await _carWriteOnlyRepository.AddCar(new Domain.CarEntity
            {
                LicensePlate = new LicensePlate(input.LicensePlate),
                Brand = input.Brand,
                Model = input.Model,
                ManufacturingYear = new ManufacturingYear(input.ManufacturingYear),
                Available = input.Available,
                Price = input.Price
            });
        }
    }
}
