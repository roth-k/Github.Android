using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
   public  class GetRepoCommitsService : IGetRepoCommitsService
    {
        public async  Task<List<Commit>> GetCommitsAsync(string url) =>
            new JsonDeserializer().Deserialize<List<Commit>>(await new DownloadManager().DownloadDataAsync(url));
       
    }
}
