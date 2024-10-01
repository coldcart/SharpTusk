using Tusk.Api;

namespace Tusk.Client;

public interface ITuskClient : IDisposable
{
    LabelsApi LabelsApi { get; }
    RatesApi RatesApi { get; }
    ShipmentsApi ShipmentsApi { get; }
    TrackingApi TrackingApi { get; }
    ManifestApi ManifestApi { get; }
    LocationsApi LocationsApi { get; }
}