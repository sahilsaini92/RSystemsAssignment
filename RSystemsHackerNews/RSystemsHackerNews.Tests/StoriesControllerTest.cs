using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RSystemsHackerNews.API.Controllers;
using RSystemsHackerNews.Business.Interfaces;
using RSystemsHackerNews.Data;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace RSystemsHackerNews.Tests
{
    [TestFixture]
    public class StoriesControllerTests
    {
        private StoriesController _storyController;

        [SetUp]
        public void Initialise()
        {
            var mockHttpContext = new Mock<HttpContext>();
            var mockRequest = new Mock<HttpRequest>();
            var queryParameters = new QueryCollection(new Dictionary<string, StringValues>
            {
                ["pageNumber"] = new StringValues("1"),
                ["pageSize"] = new StringValues("10"),
                ["searchString"] = new StringValues("")
            });

            mockRequest.SetupGet(r => r.Query).Returns(queryParameters);
            mockHttpContext.SetupGet(c => c.Request).Returns(mockRequest.Object);

            var repository = new Mock<IStoryService>();
            repository.Setup(repo => repo.GetStories("", 1, 10)).ReturnsAsync(MockData.GetStories());
            _storyController = new StoriesController(repository.Object);
            _storyController.ControllerContext = new ControllerContext
            {
                HttpContext = mockHttpContext.Object
            };
        }

        [Test]
        public async Task GetNewStories_ReturnsOkResult()
        {
            
            var result = await _storyController.GetNewStories() as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);

            var data = result.Value as ApiResponse;

            Assert.IsNotNull(data);
            Assert.AreEqual(3, data.TotalCount);
            Assert.AreEqual("Google", data.Stories.Select(s=>s.By).FirstOrDefault());
        }
    }

}