using Ledgerline.Api;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Ledgerline.Component.Tests.Fixtures;

public class ApiFixture : WebApplicationFactory<Program>
{
    internal HttpClient Client { get; }
    
    public ApiFixture()
    {
        Client  = CreateClient();
    }
}