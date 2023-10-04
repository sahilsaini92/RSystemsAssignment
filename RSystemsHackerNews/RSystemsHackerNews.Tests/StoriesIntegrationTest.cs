using System.Net.Http;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using RSystemsHackerNews.Data;
using RSystemsHackerNews.Tests;

[TestFixture]
public class IntegrationTests
{
    private HttpClient _client;

    [SetUp]
    public void SetUp()
    {
        _client = new HttpClient();
    }

    [Test]
    public async Task GetNewStories_ReturnsOkResult()
    {
        var response = await _client.GetAsync("https://rsystemshackernewsapi.azurewebsites.net/api/Stories/NewStories");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<ApiResponse>(content);
        Assert.IsNotNull(data);
    }
}
