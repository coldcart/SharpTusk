using Tusk.Api;

namespace Tusk.Client;

/// <summary>
/// Interface used for DI and testing purposes
/// </summary>
public interface ITuskClient : IDisposable
{
    /// <summary>
    /// Labels API Endpoints
    /// </summary>
    LabelsApi LabelsApi { get; }
    /// <summary>
    /// Rates API Endpoints
    /// </summary>
    RatesApi RatesApi { get; }
    /// <summary>
    /// Shipments API Endpoints
    /// </summary>
    ShipmentsApi ShipmentsApi { get; }
    /// <summary>
    /// Tracking API Endpoints
    /// </summary>
    TrackingApi TrackingApi { get; }
    /// <summary>
    /// Manifest API Endpoints
    /// </summary>
    ManifestApi ManifestApi { get; }
    /// <summary>
    /// Locations API Endpoints
    /// </summary>
    LocationsApi LocationsApi { get; }
}