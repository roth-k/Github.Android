﻿using Github.DataLayer.GitApiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Github.Services.RepositoryDataServices.Abstractions
{
   public interface IGetBranchesService
    {
        Task<List<Branch>> GetBranchesAsync(string url);
    }
}
