using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using GtMotive.Estimate.Microservice.ApplicationCore.Mappings;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories.Car;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCustomer;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.GetAvailableCars;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.RentCar;
using GtMotive.Estimate.Microservice.Infrastructure.MongoDb;
using GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Repositories;
using GtMotive.Estimate.Microservice.Infrastructure.MongoDb.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GtMotive.Estimate.Microservice.Host.DependencyInjection
{
    internal static class IoCConfig
    {
        public static void RegisterIoCContainer(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.RegisterData(configuration);
            serviceCollection.RegisterUseCases();
            serviceCollection.RegisterRepositories();
            serviceCollection.RegisterAutoMapper();
        }

        private static void RegisterData(this IServiceCollection services, IConfiguration configuration)
        {
            var keyVaultUri = configuration["MongoDb:KeyVaultUri"];
            var secretName = configuration["MongoDb:SecretName"];

            var client = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());
            var secretTask = client.GetSecretAsync(secretName);
            secretTask.Wait();
            var secretValue = secretTask.Result.Value;

            services.Configure<MongoDbSettings>(options =>
            {
                options.ConnectionString = secretValue.Value;
                options.MongoDbDatabaseName = configuration["MongoDb:MongoDbDatabaseName"];
            });
            services.AddSingleton<MongoService>();
        }

        private static void RegisterUseCases(this IServiceCollection services)
        {
            services.AddSingleton<IAddCarUseCase, AddCarUseCase>();
            services.AddSingleton<IAddCustomerUseCase, AddCustomerUseCase>();
            services.AddSingleton<IGetAvailableCarsUseCase, GetAvailableCarsUseCase>();
            services.AddSingleton<IRentCarUseCase, RentCarUseCase>();
        }

        private static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ICarReadOnlyRepository, CarRepository>();
            services.AddSingleton<ICarWriteOnlyRepository, CarRepository>();
            services.AddSingleton<ICustomerWriteOnlyRepository, CustomerRepository>();
            services.AddSingleton<IRentalOrderWriteOnlyRepository, RentalOrderWriteOnlyRepository>();
        }

        private static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
        }
    }
}
