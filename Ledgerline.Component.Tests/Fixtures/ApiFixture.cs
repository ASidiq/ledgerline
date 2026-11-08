using Ledgerline.Api;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Ledgerline.Component.Tests.Fixtures;

public class ApiFixture : WebApplicationFactory<Program>, IAsyncLifetime
{
    internal HttpClient Client { get; private set; }
    
    public ApiFixture()
    {
    }

    public Task InitializeAsync()
    {
        // setup database tbd
        
        // Create Client
        Client  = CreateClient();
        return Task.CompletedTask;
    }

    public async Task DisposeAsync()
    {
        // cleanup
        
        await base.DisposeAsync();
    }
}