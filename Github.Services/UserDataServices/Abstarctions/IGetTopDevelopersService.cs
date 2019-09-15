using Github.DataLayer.NewsModels.Develops;
using Github.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.Abstarctions
{
    public interface IGetTopDevelopersService
    {
        Task<List<Developer>> GetDevelopers(string language, TimePeriod since);
    }
}
