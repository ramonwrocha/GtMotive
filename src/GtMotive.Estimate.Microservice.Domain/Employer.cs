using GtMotive.Estimate.Microservice.Domain.Base;
using GtMotive.Estimate.Microservice.Domain.Enums;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents an employer who is a type of user.
    /// </summary>
    public sealed class Employer : UserBase
    {
        /// <summary>
        /// Gets or sets the position of the employer.
        /// </summary>
        public EmployerPosition Position { get; set; }
    }
}
