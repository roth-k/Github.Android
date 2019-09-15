using Github.DataLayer.GitApiModels;
using Github.Repository;
using Github.Services.Abstarctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Implementations
{
    public class GetFollowersService : IGetFollowersService
    {
        public async Task<List<User>> GetFollowersAsync(string url) =>
            new JsonDeserializer().Deserialize<List<User>>(await new DownloadManager().DownloadDataAsync(url));
       
    }
}
