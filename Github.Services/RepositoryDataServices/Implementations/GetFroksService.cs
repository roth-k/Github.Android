using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.RepositoryDataServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Implementations
{
    public class GetFroksService : IGetFroksService
    {
        public async Task<List<Fork>> GetFroksAsync(string url) =>
            new JsonDeserializer().Deserialize<List<Fork>>(await new DownloadManager().DownloadDataAsync(url));
       
    }
}
