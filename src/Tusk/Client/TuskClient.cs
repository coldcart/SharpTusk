using Tusk.Api;

namespace Tusk.Client;

public class TuskClient : ITuskClient
{
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

    public LabelsApi LabelsApi { get; }
    public RatesApi RatesApi { get; }
    public ShipmentsApi ShipmentsApi { get; }
    public TrackingApi TrackingApi { get; }
    public ManifestApi ManifestApi { get; }
    public LocationsApi LocationsApi { get; }
    private readonly ApiClient _apiClient;

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