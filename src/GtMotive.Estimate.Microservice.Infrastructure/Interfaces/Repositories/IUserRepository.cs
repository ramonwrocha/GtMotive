using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain.Entities;

namespace GtMotive.Estimate.Microservice.Infrastructure.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(string id);

        Task AddAsync(User usuario);

        Task UpdateAsync(User usuario);

        Task DeleteAsync(string id);
    }
}
