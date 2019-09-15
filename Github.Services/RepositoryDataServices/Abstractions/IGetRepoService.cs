using Github.DataLayer.GitApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Abstractions
{
    public interface IGetRepoService
    {
        Task<Repo> GetRepoAsync(string username, string reponame);
    }
}
