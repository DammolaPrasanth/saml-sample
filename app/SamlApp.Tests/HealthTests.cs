using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using FluentAssertions;

namespace SamlApp.Tests;

public class HealthTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public HealthTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Health_endpoint_returns_ok()
    {
        var client = _factory.CreateClient();
        var res = await client.GetAsync("/home/health");
        res.EnsureSuccessStatusCode();
        var s = await res.Content.ReadAsStringAsync();
        s.Should().Contain("healthy");
    }
}
