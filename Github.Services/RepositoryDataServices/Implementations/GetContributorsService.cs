using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
    public class GetContributorsService : IGetContributorsService
    {
        public async Task<List<Contributor>> GetContributorsAsync(string url) =>
            new JsonDeserializer().Deserialize<List<Contributor>>(await new DownloadManager().DownloadDataAsync(url));
            
        
    }
}
