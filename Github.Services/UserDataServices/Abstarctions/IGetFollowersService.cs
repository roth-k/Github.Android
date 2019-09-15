using Github.DataLayer.GitApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Abstarctions
{
    public interface IGetFollowersService
    {
        Task<List<User>> GetFollowersAsync(string url);
    }
}
