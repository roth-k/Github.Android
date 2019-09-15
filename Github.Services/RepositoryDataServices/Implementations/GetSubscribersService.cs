using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
    public class GetSubscribersService : IGetSubscribersService
    {
        public async Task<List<User>> GetSubscribersAsync(string url)=>
            new JsonDeserializer().Deserialize<List<User>>(await new DownloadManager().DownloadDataAsync(url));
    }
}
