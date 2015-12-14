using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface ISolverRepository
    {
        Task Add(Solver solver);
        Task<Solver> Remove(string id);
        Task<List<Solver>> FindAll();
        Task<Solver> Find(string id);
        Task Update(string id, Solver solver);
    }
}
