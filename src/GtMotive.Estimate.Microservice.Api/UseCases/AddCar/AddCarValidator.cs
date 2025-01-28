using FluentValidation;

namespace GtMotive.Estimate.Microservice.Api.UseCases.AddCar
{
    public class AddCarValidator : AbstractValidator<CarRequest>
    {
        public AddCarValidator()
        {
            RuleFor(x => x.LicensePlate).NotEmpty().WithMessage("LicensePlate is required.");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Brand is required.");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model is required.");
            RuleFor(x => x.Available).NotNull().WithMessage("Available is required.");
            RuleFor(x => x.ManufacturingDate).NotNull().WithMessage("ManufacturingDate is required.");
        }
    }
}
