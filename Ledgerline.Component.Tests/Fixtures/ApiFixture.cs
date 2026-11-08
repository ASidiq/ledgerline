using Ledgerline.Api;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Ledgerline.Component.Tests.Fixtures;

public class ApiFixture : WebApplicationFactory<Program>, IAsyncLifetime
{
    internal HttpClient Client { get; private set; } = null!;


    public Task InitializeAsync()
    {
        // setup database tbd
        
        // Create Client
        Client  = CreateClient();
        return Task.CompletedTask;
    }

    /**
     * Using new to acknowledge that DisposeAsync hides a virtual method of the same name
     * defined by WebApplicationFactory. Cannot override that method as IAsyncLifetime
     * declares a method with the same name but a different return type (Task vs ValueTask).
     * Code that disposes the fixture through IAsyncDisposable or await using skips this cleanup e.g.
     * ApiFixture.DisposeAsync calls this method but WebApplicationFactory<Program>.DisposeAsync will not.
    **/
    public new async Task DisposeAsync()
    {
        // cleanup
        
        await base.DisposeAsync();
    }
}