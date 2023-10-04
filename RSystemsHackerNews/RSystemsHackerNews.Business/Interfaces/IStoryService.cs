using RSystemsHackerNews.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSystemsHackerNews.Business.Interfaces
{
    public interface IStoryService
    {
        Task<ApiResponse> GetStories(string searchText, int pageNumber,int pageSize);

        Task<HttpResponseMessage> GetStoryByIdAsync(int id);

    }
}
