using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Tusk.Client;

/// <summary>
/// Helper class for registering TuskClient with the DI container.
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Registers TuskClient and its dependencies with the DI container.
    /// </summary>
    /// <param name="services">The IServiceCollection to add services to.</param>
    /// <param name="configureOptions">An action to configure TuskClientOptions.</param>
    /// <param name="useRetryHandler">Whether to include RetryHandler.</param>
    /// <returns>The updated IServiceCollection.</returns>
    public static IServiceCollection AddTuskClient(this IServiceCollection services, Action<TuskClientOptions> configureOptions, bool useRetryHandler = false)
    {
        if (configureOptions == null) throw new ArgumentNullException(nameof(configureOptions));

        services.Configure(configureOptions);
        
        services.AddSingleton<IReadableConfiguration>(sp =>
        {
            var options = sp.GetRequiredService<IOptions<TuskClientOptions>>().Value;
            return new ReadableConfiguration(options);
        });

        if (useRetryHandler)
        {
            services.AddTransient<RetryHandler>(sp =>
            {
                var options = sp.GetRequiredService<IOptions<TuskClientOptions>>().Value;
                return new RetryHandler(options.MaxRetries, options.RetryDelay);
            });
        }

        var httpClientBuilder = services.AddHttpClient("TuskClient", (sp, client) =>
        {
            var options = sp.GetRequiredService<IOptions<TuskClientOptions>>().Value;
            client.BaseAddress = new Uri(options.BaseUrl);
            client.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
        });

        if (useRetryHandler)
        {
            httpClientBuilder.AddHttpMessageHandler<RetryHandler>();
        }

        services.AddScoped<ApiClient>(sp =>
        {
            var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
            var httpClient = httpClientFactory.CreateClient("TuskClient");
            if (useRetryHandler)
            {
                var retryHandler = sp.GetRequiredService<RetryHandler>();

                return new ApiClient(httpClient, retryHandler: retryHandler);
            }
            return new ApiClient(httpClient);
        });
        if (useRetryHandler)
        {
            httpClientBuilder.AddHttpMessageHandler<RetryHandler>();
        }

        services.AddScoped<TuskClient>(sp =>
        {
            var apiClient = sp.GetRequiredService<ApiClient>();
            var configuration = sp.GetRequiredService<IReadableConfiguration>();
            return new TuskClient(apiClient, configuration);
        });
        
        services.AddScoped<ITuskClient>(sp => sp.GetRequiredService<TuskClient>());


        return services;
    }
    
    /// <summary>
    /// Creates a new instance of TuskClient.
    /// </summary>
    /// <param name="configureOptions">An action to configure TuskClientOptions.</param>
    /// <param name="useRetryHandler">Whether to include RetryHandler.</param>
    /// <param name="httpMessageHandler">An optional HttpMessageHandler.</param>
    /// <returns>An instance of TuskClient.</returns>
    public static TuskClient Create(Action<TuskClientOptions> configureOptions, bool useRetryHandler = false, HttpMessageHandler? httpMessageHandler = null)
    {
        if (configureOptions == null) throw new ArgumentNullException(nameof(configureOptions));

        var options = new TuskClientOptions();
        configureOptions(options);
        var configuration = new ReadableConfiguration(options);

        ApiClient apiClient;

        if (useRetryHandler)
        {
            var retryHandler = new RetryHandler(options.MaxRetries, options.RetryDelay)
            {
                InnerHandler = httpMessageHandler ?? new HttpClientHandler()
            };
            var httpClient = new HttpClient(retryHandler)
            {
                BaseAddress = new Uri(options.BaseUrl)
            };
            httpClient.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
            apiClient = new ApiClient(options.BaseUrl, retryHandler);
        }
        else
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(options.BaseUrl)
            };
            httpClient.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
            apiClient = new ApiClient(options.BaseUrl);
        }

        return new TuskClient(apiClient, configuration);
    }
}