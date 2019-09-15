using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
    public class GetBranchesService : IGetBranchesService
    {
        public async Task<List<Branch>> GetBranchesAsync(string url) =>
            new JsonDeserializer().Deserialize<List<Branch>>(await new DownloadManager().DownloadDataAsync(url));
        
    }
}
