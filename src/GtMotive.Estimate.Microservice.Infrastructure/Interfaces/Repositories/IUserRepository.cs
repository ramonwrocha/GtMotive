using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain.Entities.Base;

namespace GtMotive.Estimate.Microservice.Infrastructure.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<UserBase> GetByIdAsync(string id);

        Task AddAsync(UserBase usuario);

        Task UpdateAsync(UserBase usuario);

        Task DeleteAsync(string id);
    }
}
