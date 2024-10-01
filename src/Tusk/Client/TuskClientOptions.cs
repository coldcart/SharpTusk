namespace Tusk.Client;

public class TuskClientOptions
{
    /// <summary>
    /// The base URL of the Tusk API.
    /// </summary>
    public string BaseUrl { get; set; } = "https://api.tusklogistics.com";

    /// <summary>
    /// The API key for authentication.
    /// </summary>
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// Maximum number of retry attempts.
    /// </summary>
    public int MaxRetries { get; set; } = 3;

    /// <summary>
    /// Delay between retry attempts.
    /// </summary>
    public TimeSpan RetryDelay { get; set; } = TimeSpan.FromSeconds(2);
}