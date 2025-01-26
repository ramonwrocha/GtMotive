using GtMotive.Estimate.Microservice.Domain.Entities.Base;
using GtMotive.Estimate.Microservice.Domain.Entities.Enums;

namespace GtMotive.Estimate.Microservice.Domain.Entities
{
    /// <summary>
    /// Represents an employer who is a type of user.
    /// </summary>
    public class Employer : UserBase
    {
        /// <summary>
        /// Gets or sets the position of the employer.
        /// </summary>
        public EmployerPosition Position { get; set; }
    }
}
