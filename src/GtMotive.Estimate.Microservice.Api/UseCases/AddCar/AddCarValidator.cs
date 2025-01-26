using System;
using FluentValidation;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public class AddCarValidator : AbstractValidator<CarRequest>
    {
        private const int MinimumYearsManufacturing = 5;

        public AddCarValidator()
        {
            RuleFor(x => x.LicensePlate).NotEmpty().WithMessage("LicensePlate is required.");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Brand is required.");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model is required.");
            RuleFor(x => x.Available).NotNull().WithMessage("Available is required.");
            RuleFor(x => x.ManufacturingDate).NotNull().WithMessage("Available is required.")
                .Must(IsValidManufacturingDate).WithMessage($"La fecha debe estar dentro de los últimos {MinimumYearsManufacturing} años.");
        }

        private bool IsValidManufacturingDate(DateTime date)
        {
            return date >= DateTime.Now.AddYears(-MinimumYearsManufacturing) && date <= DateTime.Now;
        }
    }
}
