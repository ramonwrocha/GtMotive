using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.Domain;
using MongoDB.Driver;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Repositories
{
    public class CustomerRepository(MongoService context) : ICustomerWriteOnlyRepository
    {
        private readonly MongoService _context = context;

        public async Task AddCustomer(CustomerEntity customer)
        {
            await _context.Customers.InsertOneAsync(customer);
        }

        public Task<CustomerEntity> GetCustomerByDocumentNumber(string documentNumber)
        {
            return _context.Customers.Find(c => c.DocumentNumber == documentNumber).SingleOrDefaultAsync();
        }
    }
}
