using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWithIoC
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var config = CreateConfigurationBuilder(args).Build();
            Console.WriteLine("Hello, World!");
        }

        private static IConfigurationBuilder CreateConfigurationBuilder(string[] args)
        {
            var builder = new ConfigurationBuilder();

            return builder
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty)
                .AddJsonFile("appSettings.json", false, false)
                .AddEnvironmentVariables();
        }
    }
}