using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Services;
using Module2HW4.Providers;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddTransient<ICountService, CountService>()
                .AddTransient<ISafariService, SafariService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}