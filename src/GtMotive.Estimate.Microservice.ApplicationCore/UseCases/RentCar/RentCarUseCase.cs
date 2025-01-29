using System;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar
{
    /// <summary>
    /// Use case for renting a car.
    /// </summary>
    public class RentCarUseCase(IRentalOrderWriteOnlyRepository rentalOrderWriteOnlyRepository, ICustomerWriteOnlyRepository customerWriteOnlyRepository, ICarReadOnlyRepository carReadOnlyRepository) : IRentCarUseCase
    {
        private readonly IRentalOrderWriteOnlyRepository rentalOrderWriteOnlyRepository = rentalOrderWriteOnlyRepository;
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository = customerWriteOnlyRepository;
        private readonly ICarReadOnlyRepository carReadOnlyRepository = carReadOnlyRepository;

        /// <summary>
        /// Executes the use case for renting a car.
        /// </summary>
        /// <param name="input">The input data for renting a car.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task Execute(RentCarInput input)
        {
            ArgumentNullException.ThrowIfNull(input);

            await CheckOrderAsync(input.CarLicensePlate);

            var customer = await GetCustomer(input.DocumentNumberCustomer);

            var car = await GetCar(input.CarLicensePlate);

            var entity = new RentalOrderEntity
            {
                Customer = customer,
                Car = car,
                RentalStartDate = input.RentalStartDate,
                RentalEndDate = input.RentalEndDate,
                TotalPrice = CalculateTotalPrice(input.RentalStartDate, input.RentalEndDate, car.Price),
                Delivered = false
            };

            await rentalOrderWriteOnlyRepository.RentCar(entity);
        }

        private static decimal CalculateTotalPrice(DateTime rentalStartDate, DateTime rentalEndDate, decimal price)
        {
            return price * (rentalEndDate - rentalStartDate).Days;
        }

        private async Task<CarEntity> GetCar(string carLicensePlate)
        {
            var car = await carReadOnlyRepository.GetCarByLicensePlate(carLicensePlate);
            return car ?? throw new InvalidOperationException("Car not found.");
        }

        private async Task<CustomerEntity> GetCustomer(string documentNumberCustomer)
        {
            var customer = await customerWriteOnlyRepository.GetCustomerByDocumentNumber(documentNumberCustomer);
            return customer ?? throw new InvalidOperationException("Customer not found.");
        }

        private async Task CheckOrderAsync(string carLicensePlate)
        {
            var order = await rentalOrderWriteOnlyRepository.GetRentalOrderByCustomer(carLicensePlate);
            if (order is not null)
            {
                throw new InvalidOperationException("The customer already has a rental order.");
            }
        }
    }
}
