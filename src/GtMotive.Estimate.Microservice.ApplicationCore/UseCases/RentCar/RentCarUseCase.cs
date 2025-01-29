using System.Threading.Tasks;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar
{
    /// <summary>
    /// Use case for renting a car.
    /// </summary>
    public class RentCarUseCase : IRentCarUseCase
    {
        /// <summary>
        /// Executes the rent car use case with the specified input.
        /// </summary>
        /// <param name="input">The input data for renting a car.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public Task Execute(RentCarInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}
