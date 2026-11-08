using System.Net;
using FluentAssertions;
using Ledgerline.Component.Tests.Fixtures;

namespace Ledgerline.Component.Tests;

public class ApiTests : IClassFixture<ApiFixture>
{
    private readonly ApiFixture _apiFixture;
    public ApiTests(ApiFixture apiFixture)
    {
        _apiFixture = apiFixture;
    }
    [Fact]
    public async Task ShouldReturnOk_When_Get_Endpoint_IsCalled()
    {
        // Arrange & Act
        var response = await _apiFixture.Client.GetAsync("/");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}