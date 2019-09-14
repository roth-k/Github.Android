using Github.DataLayer.GitApiModels;
using Github.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Abstarctions
{
   public interface IGetTopReposService
    {
        Task<List<Repo>> GetRepos(string language, TimePeriod since);

    }
}
