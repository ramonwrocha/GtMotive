using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer
{
    /// <summary>
    /// Use case for adding a customer.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="AddCustomerUseCase"/> class.
    /// </remarks>
    /// <param name="customerWriteOnlyRepository">The customer repository.</param>
    public class AddCustomerUseCase(ICustomerWriteOnlyRepository customerWriteOnlyRepository) : IAddCustomerUseCase
    {
        private readonly ICustomerWriteOnlyRepository _customerWriteOnlyRepository = customerWriteOnlyRepository;

        /// <summary>
        /// Executes the use case to add a customer.
        /// </summary>
        /// <param name="input">The input data for adding a customer.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input is null.</exception>
        public async Task Execute(AddCustomerInput input)
        {
            ArgumentNullException.ThrowIfNull(input);

            await _customerWriteOnlyRepository.AddCustomer(new CustomerEntity
            {
                DocumentNumber = input.DocumentNumber,
                Name = input.Name,
                Email = input.Email
            });
        }
    }
}
