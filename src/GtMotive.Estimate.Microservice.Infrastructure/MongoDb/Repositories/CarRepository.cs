using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car;
using GtMotive.Estimate.Microservice.Domain;
using MongoDB.Driver;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Repositories
{
    public class CarRepository(MongoService context) : ICarReadOnlyRepository, ICarWriteOnlyRepository
    {
        private readonly MongoService _context = context;

        public async Task AddCar(CarEntity car)
        {
            await _context.Cars.InsertOneAsync(car);
        }

        public async Task<IEnumerable<CarEntity>> GetAvailableCars()
        {
            var filter = Builders<CarEntity>.Filter.Eq(c => c.Available, true);
            var result = await _context.Cars.FindAsync(filter);
            return await result.ToListAsync();
        }

        public async Task<CarEntity> GetCar(Guid id)
        {
            var filter = Builders<CarEntity>.Filter.Eq(c => c.Id, id);
            var result = await _context.Cars.FindAsync(filter);
            return await result.SingleOrDefaultAsync();
        }
    }
}
