using Airplane.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Airplane.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceProvider BuildServiceProvider()
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<IReadInputService, ReadInputService>()
                .AddScoped<IAirplaneService, AirplaneService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
