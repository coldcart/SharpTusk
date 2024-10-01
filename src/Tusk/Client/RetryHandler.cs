using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Tusk.Client;

public class RetryHandler : DelegatingHandler
{
    private readonly int _maxRetries;
    private readonly TimeSpan _delay;

    /// <summary>
    /// Initializes a new instance of the <see cref="RetryHandler"/> class.
    /// </summary>
    /// <param name="maxRetries">The maximum number of retry attempts.</param>
    /// <param name="delay">The delay between retry attempts.</param>
    public RetryHandler(int maxRetries = 3, TimeSpan? delay = null)
    {
        _maxRetries = maxRetries;
        _delay = delay ?? TimeSpan.FromSeconds(0);
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        for (int retry = 0; retry <= _maxRetries; retry++)
        {
            try
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                // Check if we should retry based on the status code
                if (ShouldRetry(response.StatusCode) && retry < _maxRetries)
                {
                    await Task.Delay(_delay, cancellationToken).ConfigureAwait(false);
                    continue;
                }

                return response;
            }
            catch (HttpRequestException) when (retry < _maxRetries)
            {
                await Task.Delay(_delay, cancellationToken).ConfigureAwait(false);
            }
        }
        throw new HttpRequestException($"Request to {request.RequestUri} failed after {_maxRetries} retries.");
    }

    private bool ShouldRetry(System.Net.HttpStatusCode statusCode)
    {
        return statusCode == System.Net.HttpStatusCode.RequestTimeout ||
               statusCode == System.Net.HttpStatusCode.InternalServerError ||
               statusCode == System.Net.HttpStatusCode.BadGateway ||
               statusCode == System.Net.HttpStatusCode.ServiceUnavailable ||
               statusCode == System.Net.HttpStatusCode.GatewayTimeout;
    }
}