using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.Abstarctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Implementations
{
    public class GetDeveloperService : IGetDeveloperService
    {
        public async Task<Developer> GetDeveloperAsync(string username) =>
            new JsonDeserializer().Deserialize<Developer>(await new DownloadManager().DownloadDataAsync
                (ApiManager.Instance.GitDeveloperApiEndpoint(username)));
        
    }
}
