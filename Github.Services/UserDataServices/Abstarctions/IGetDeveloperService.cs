using Github.DataLayer.GitApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Abstarctions
{
    public interface IGetDeveloperService
    {
        Task<Developer> GetDeveloperAsync(string username);
    }
}
