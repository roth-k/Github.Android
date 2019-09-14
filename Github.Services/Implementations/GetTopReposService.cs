using Github.DataLayer.GitApiModels;
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
        public async Task<List<Repo>> GetRepos(string language, TimePeriod since)=>
             new JsonDeserializer().Deserialize <List<Repo>>
                 (await new DownloadManager().DownloadNewsFeedDataAsync
                 (ApiManager.Instance.TrendingReposEndpoint(language, since)));
       
    }
}
