using System;

namespace GtMotive.Estimate.Microservice.Domain.ValueObjects
{
    /// <summary>
    /// Represents a vehicle's license plate.
    /// </summary>
    public sealed class LicensePlate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePlate"/> class.
        /// </summary>
        /// <param name="value">The license plate value.</param>
        /// <exception cref="ArgumentException">Thrown when the license plate is null, empty, or longer than 7 characters.</exception>
        public LicensePlate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("License plate cannot be null or empty", nameof(value));
            }

            if (value.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 characters", nameof(value));
            }

            Value = value;
        }

        /// <summary>
        /// Gets the license plate value.
        /// </summary>
        public string Value { get; }
    }
}
