using System.Net;
using FluentAssertions;
using Ledgerline.Component.Tests.Fixtures;

namespace Ledgerline.Component.Tests;

public class ApiTests : ApiFixture
{
    [Fact]
    public async Task ShouldReturnOk_When_Get_Endpoint_IsCalled()
    {
        // Arrange
        var expectedText = "Hello World!";
        
        // Act
        var response = await Client.GetAsync("/");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var responseText = await response.Content.ReadAsStringAsync();
        responseText.Should().Be(expectedText);
    }
}