using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Tusk.Client;
using Tusk.Model;
using Xunit;

namespace Tusk.Test.Client;

public class RegistrationTests
{
    private const string BaseUrl = "https://apisandbox.tusklogistics.com";
    private const string ApiKey = "SANDBOX_API_KEY";
    [Fact]
    public void AddTuskClient_RegistersServicesCorrectly()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddTuskClient(options =>
        {
            options.BaseUrl = BaseUrl;
            options.ApiKey = "test-api-key";
            options.MaxRetries = 3;
            options.RetryDelay = TimeSpan.FromSeconds(2);
        }, useRetryHandler: true);

        var serviceProvider = services.BuildServiceProvider();

        // Assert
        Assert.NotNull(serviceProvider.GetService<ITuskClient>());
        Assert.NotNull(serviceProvider.GetService<TuskClient>());
        Assert.NotNull(serviceProvider.GetService<ApiClient>());
        Assert.NotNull(serviceProvider.GetService<IReadableConfiguration>());
    }

    [Fact]
    public void Create_ReturnsValidTuskClient()
    {
        // Act
        var tuskClient = Helpers.Create(options =>
        {
            options.BaseUrl = BaseUrl;
            options.ApiKey = "test-api-key";
            options.MaxRetries = 3;
            options.RetryDelay = TimeSpan.FromSeconds(2);
        }, useRetryHandler: true);

        // Assert
        Assert.NotNull(tuskClient);
        Assert.IsType<TuskClient>(tuskClient);
    }
    
    [Fact]
        public async Task LocationsApi_WithDI_NoRetry_ShouldReturnLocations()
        {
            // Arrange
            var services = new ServiceCollection();
            services.AddTuskClient(options =>
            {
                options.BaseUrl = BaseUrl;
                options.ApiKey = ApiKey;
            }, useRetryHandler: false);

            var serviceProvider = services.BuildServiceProvider();
            var tuskClient = serviceProvider.GetRequiredService<ITuskClient>();

            // Act
            var locations = await tuskClient.LocationsApi.GetallshipfromLocationsAsync();

            // Assert
            Assert.NotNull(locations);
            Assert.IsType<List<Location>>(locations);
        }

        [Fact]
        public async Task LocationsApi_WithDI_WithRetry_ShouldReturnLocations()
        {
            // Arrange
            var services = new ServiceCollection();
            services.AddTuskClient(options =>
            {
                options.BaseUrl = BaseUrl;
                options.ApiKey = ApiKey;
                options.MaxRetries = 3;
                options.RetryDelay = TimeSpan.FromSeconds(1);
            }, useRetryHandler: true);

            var serviceProvider = services.BuildServiceProvider();
            var tuskClient = serviceProvider.GetRequiredService<ITuskClient>();

            // Act
            var locations = await tuskClient.LocationsApi.GetallshipfromLocationsAsync();

            // Assert
            Assert.NotNull(locations);
            Assert.IsType<List<Location>>(locations);
        }

        [Fact]
        public async Task LocationsApi_ManualCreation_NoRetry_ShouldReturnLocations()
        {
            // Arrange
            var tuskClient = Helpers.Create(options =>
            {
                options.BaseUrl = BaseUrl;
                options.ApiKey = ApiKey;
            }, useRetryHandler: false);

            // Act
            var locations = await tuskClient.LocationsApi.GetallshipfromLocationsAsync();

            // Assert
            Assert.NotNull(locations);
            Assert.IsType<List<Location>>(locations);
        }

        [Fact]
        public async Task LocationsApi_ManualCreation_WithRetry_ShouldReturnLocations()
        {
            // Arrange
            var tuskClient = Helpers.Create(options =>
            {
                options.BaseUrl = BaseUrl;
                options.ApiKey = ApiKey;
                options.MaxRetries = 3;
                options.RetryDelay = TimeSpan.FromSeconds(1);
            }, useRetryHandler: true);

            // Act
            var locations = await tuskClient.LocationsApi.GetallshipfromLocationsAsync();

            // Assert
            Assert.NotNull(locations);
            Assert.IsType<List<Location>>(locations);
        }
}
