using GtMotive.Estimate.Microservice.Domain;
using GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace GtMotive.Estimate.Microservice.Infrastructure.MongoDb
{
    public class MongoService
    {
        private readonly IMongoDatabase _database;

        public MongoService(IOptions<MongoDbSettings> options)
        {
            var settings = options.Value;

            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.MongoDbDatabaseName);
            Map();
        }

        public IMongoCollection<CarEntity> Cars => _database.GetCollection<CarEntity>("Cars");

        public IMongoCollection<Order> Orders => _database.GetCollection<Order>("Orders");

        public IMongoCollection<CustomerEntity> Customers => _database.GetCollection<CustomerEntity>("Customers");

        public IMongoCollection<Employer> Employers => _database.GetCollection<Employer>("Employers");

        private static void Map()
        {
            BsonClassMap.RegisterClassMap<CarEntity>(item =>
            {
                item.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Order>(item =>
            {
                item.AutoMap();
            });

            BsonClassMap.RegisterClassMap<CustomerEntity>(item =>
            {
                item.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Employer>(item =>
            {
                item.AutoMap();
            });
        }
    }
}
