using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.Domain.Entities;

namespace GtMotive.Estimate.Microservice.Infrastructure.Interfaces.Repositories
{
    public interface ICar
    {
        Task<Car> GetByIdAsync(string id);

        Task AddAsync(Car car);

        Task UpdateAsync(Car car);

        Task DeleteAsync(string id);
    }
}
