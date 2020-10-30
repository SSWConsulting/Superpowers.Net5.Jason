using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Net5Superpowers.WebUI.IntegrationTests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration((context, configBuilder) =>
            {
                configBuilder.AddInMemoryCollection(new Dictionary<string, string>
                {
                    {"ConnectionStrings:DefaultConnection", _connectionString}
                });
            });
        }

        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=Net5Superpowers_Testing;Trusted_Connection=True;MultipleActiveResultSets=true";
    }
}
