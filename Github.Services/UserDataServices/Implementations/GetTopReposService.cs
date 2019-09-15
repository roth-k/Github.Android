using Github.DataLayer.NewsModels.Repos;
using Github.Repository;
using Github.Services.Abstarctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Implementations
{
    public class GetTopReposService : IGetTopReposService
    {
        public async Task<List<Reposit>> GetRepos(string language, TimePeriod since)=>
            new JsonDeserializer().Deserialize<List<Reposit>>
                 (await new DownloadManager().DownloadNewsFeedDataAsync
                 (ApiManager.Instance.TrendingReposEndpoint(language, since)));
         
    }
}
