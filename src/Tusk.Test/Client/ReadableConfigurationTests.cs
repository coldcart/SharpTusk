using Tusk.Client;
using Xunit;

namespace Tusk.Test.Client;

public class ReadableConfigurationTests 
{
    [Fact]
    public void CanCreateReadableConfigurationFromOptions()
    {
        var clientOptions = new TuskClientOptions
        {
            BaseUrl = "https://apisandbox.tusklogistics.com",
            ApiKey = "API_KEY",
        };
        var configuration = new ReadableConfiguration(clientOptions);
        Assert.Equal("https://apisandbox.tusklogistics.com", configuration.BasePath);
    }
    
}