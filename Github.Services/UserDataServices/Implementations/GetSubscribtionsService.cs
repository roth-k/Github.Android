using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.Abstarctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Implementations
{
    public class GetSubscribtionsService : IGetSubscribtionsService
    {
        public async Task<List<Repo>> GetSubscribtionsAsync(string url) =>
            new JsonDeserializer().Deserialize<List<Repo>>(await new DownloadManager().DownloadDataAsync(url));
       
    }
}
