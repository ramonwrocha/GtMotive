namespace GtMotive.Estimate.Microservice.Domain.Base
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class UserBase
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        public string Email { get; set; }
    }
}
