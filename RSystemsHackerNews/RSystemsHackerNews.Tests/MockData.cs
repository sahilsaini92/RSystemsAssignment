using RSystemsHackerNews.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSystemsHackerNews.Tests
{
    public static class MockData
    {
        public static ApiResponse GetStories()
        {
            IEnumerable<Task<Story>> tasks = Enumerable.Empty<Task<Story>>();
            ApiResponse apiResponse = new ApiResponse()
            {
                Stories = new List<Story>()
                {
                    new Story()
                    {
                        By="Google",
                        Title="Google News",
                        Url="www.google.com"
                    },
                    new Story()
                    {
                        By="Yahoo",
                        Title="Yahoo News",
                        Url="www.Yahoo.com"
                    },
                    new Story()
                    {
                        By="Rediff",
                        Title="Rediff News",
                        Url="www.Rediff.com"
                    }
                },
                TotalCount = 3
            };
            return apiResponse;
        }
    }
}
