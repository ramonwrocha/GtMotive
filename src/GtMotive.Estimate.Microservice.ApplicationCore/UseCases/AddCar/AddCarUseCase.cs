using System.Threading.Tasks;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar
{
    /// <summary>
    /// Use case for adding a car.
    /// </summary>
    public class AddCarUseCase : IUseCase<AddCarInput>
    {
        /// <summary>
        /// Executes the use case with the specified input.
        /// </summary>
        /// <param name="input">The input for the use case.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task Execute(AddCarInput input)
        {
            // Implementation here
            await Task.CompletedTask;
        }
    }
}
