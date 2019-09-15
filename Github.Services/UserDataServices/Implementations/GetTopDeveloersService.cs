using Github.DataLayer.NewsModels.Develops;
using Github.Repository;
using Github.Services.Abstarctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Implementations
{
    public class GetTopDeveloersService : IGetTopDevelopersService
    {
        public async Task<List<Developer>> GetDevelopers(string language, TimePeriod since) =>
             new JsonDeserializer().Deserialize<List<Developer>>(await new DownloadManager()
                 .DownloadNewsFeedDataAsync(ApiManager.Instance.TrendingDevelopersEndpoint(language,since)));
       
    }
}
