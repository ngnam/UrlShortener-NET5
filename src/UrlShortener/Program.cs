using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text;
using UrlShortener.Implements;
using UrlShortener.Interfaces;

namespace UrlShortener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var services = new ServiceCollection();

            services.AddScoped<IShortenerService, ShortenerService>();

            var serviceProvider = services.BuildServiceProvider();

            var shortenerService = serviceProvider.GetRequiredService<IShortenerService>();

            Console.WriteLine($"{shortenerService.HandleShortenUrl("https://medium.com/swlh/fast-builds-make-a-url-shortener-with-net-ff3d9206c503", "https", "nam.ly")}");

            Console.ReadLine();
        }
    }
}
