using Tusk.Api;

namespace Tusk.Client;

/// <summary>
/// Tusk Client implementation to call available APIs
/// </summary>
public class TuskClient : ITuskClient
{
    /// <summary>
    /// Dispose client implementation
    /// </summary>
    public void Dispose()
    {
        _apiClient.Dispose();
        LabelsApi.Dispose();
        RatesApi.Dispose();
        ShipmentsApi.Dispose();
        TrackingApi.Dispose();
        ManifestApi.Dispose();
        LocationsApi.Dispose();
    }

    /// <summary>
    /// Labels API Endpoints
    /// </summary>
    public LabelsApi LabelsApi { get; }
    /// <summary>
    /// Rates API Endpoints
    /// </summary>
    public RatesApi RatesApi { get; }
    /// <summary>
    /// Shipments API Endpoints
    /// </summary>
    public ShipmentsApi ShipmentsApi { get; }
    /// <summary>
    /// Tracking API Endpoints
    /// </summary>
    public TrackingApi TrackingApi { get; }
    /// <summary>
    /// Manifest API Endpoints
    /// </summary>
    public ManifestApi ManifestApi { get; }
    /// <summary>
    /// Locations API Endpoints
    /// </summary>
    public LocationsApi LocationsApi { get; }
    private readonly ApiClient _apiClient;

    /// <summary>
    /// Initialize a new TuskClient
    /// </summary>
    /// <param name="apiClient">ApiClient implementation</param>
    /// <param name="configuration">Configuration for the client</param>
    public TuskClient(ApiClient apiClient, IReadableConfiguration configuration)
    {
        _apiClient = apiClient;
        LabelsApi = new LabelsApi(_apiClient, _apiClient, configuration);
        RatesApi = new RatesApi(_apiClient, _apiClient, configuration);
        ShipmentsApi = new ShipmentsApi(_apiClient, _apiClient, configuration);
        TrackingApi = new TrackingApi(_apiClient, _apiClient, configuration);
        ManifestApi = new ManifestApi(_apiClient, _apiClient, configuration);
        LocationsApi = new LocationsApi(_apiClient, _apiClient, configuration);
    }
}