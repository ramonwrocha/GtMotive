using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.Domain;
using MongoDB.Driver;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Repositories
{
    public class RentalOrderWriteOnlyRepository(MongoService context) : IRentalOrderWriteOnlyRepository
    {
        private readonly MongoService _context = context;

        public async Task RentCar(RentalOrderEntity entity)
        {
            await _context.Orders.InsertOneAsync(entity);
        }

        public async Task<RentalOrderEntity> GetRentalOrderByCustomer(string documentNumber)
        {
            var filter = Builders<RentalOrderEntity>.Filter.And(
                Builders<RentalOrderEntity>.Filter.Eq(order => order.Customer.DocumentNumber, documentNumber),
                Builders<RentalOrderEntity>.Filter.Eq(order => order.Delivered, false));

            return await _context.Orders.Find(filter).SingleOrDefaultAsync();
        }
    }
}
