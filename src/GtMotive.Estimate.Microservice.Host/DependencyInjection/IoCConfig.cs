using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using GtMotive.Estimate.Microservice.ApplicationCore.Mappings;
using GtMotive.Estimate.Microservice.ApplicationCore.Repositories;
using GtMotive.Estimate.Microservice.ApplicationCore.UseCases.AddCar;
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
        }

        private static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ICarReadOnlyRepository, CarRepository>();
            services.AddSingleton<ICarWriteOnlyRepository, CarRepository>();
        }

        private static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
        }
    }
}
