using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.Domain;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Repositories
{
    public class CustomerRepository(MongoService context) : ICustomerWriteOnlyRepository
    {
        private readonly MongoService _context = context;

        public async Task AddCustomer(CustomerEntity customer)
        {
            await _context.Customers.InsertOneAsync(customer);
        }
    }
}
