using GtMotive.Estimate.Microservice.Domain.Bases;
using GtMotive.Estimate.Microservice.Domain.Enums;

namespace GtMotive.Estimate.Microservice.Domain
{
    /// <summary>
    /// Represents an employer who is a type of user.
    /// </summary>
    public sealed class Employer : EntityBase
    {
        /// <summary>
        /// Gets or sets the position of the employer.
        /// </summary>
        public EmployerPosition Position { get; set; }
    }
}
