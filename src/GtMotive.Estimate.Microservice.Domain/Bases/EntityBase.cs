using System;

namespace GtMotive.Estimate.Microservice.Domain.Bases
{
    /// <summary>
    /// Represents the base class for all entities with a unique identifier.
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public Guid Id { get; set; }
    }
}
