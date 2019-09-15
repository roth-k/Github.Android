using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
    public class GetRepoService : IGetRepoService
    {
        public async Task<Repo> GetRepoAsync(string username, string reponame)=>
            new JsonDeserializer().Deserialize<Repo>(await new DownloadManager().DownloadDataAsync
                (ApiManager.Instance.GitRepoApiEndpoint(username,reponame)));

    }
}
