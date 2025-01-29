using System;

namespace GtMotive.Estimate.Microservice.Domain.ValueObjects
{
    /// <summary>
    /// Represents the manufacturing date of a product.
    /// </summary>
    public sealed class ManufacturingYear
    {
        private const int MinimumYearsManufacturing = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManufacturingYear"/> class.
        /// </summary>
        /// <param name="value">The manufacturing date value.</param>
        /// <exception cref="ArgumentNullException">Thrown when the manufacturing date is empty.</exception>
        /// <exception cref="ArgumentException">Thrown when the manufacturing date is not within the last 5 years.</exception>
        public ManufacturingYear(int value)
        {
            if (value == default)
            {
                throw new ArgumentNullException(nameof(value), "The manufacturing date cannot be empty.");
            }

            if (!IsValidManufacturingYear(value))
            {
                throw new ArgumentException($"The date must be within the last {MinimumYearsManufacturing} years.", nameof(value));
            }

            Value = value;
        }

        /// <summary>
        /// Gets the manufacturing date value.
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Validates if the manufacturing date is within the last 5 years.
        /// </summary>
        /// <param name="year">The date to validate.</param>
        /// <returns>True if the date is within the last 5 years; otherwise, false.</returns>
        private static bool IsValidManufacturingYear(int year)
        {
            var yearValid = DateTime.Now.AddYears(-MinimumYearsManufacturing).Year;
            return year >= yearValid;
        }
    }
}
