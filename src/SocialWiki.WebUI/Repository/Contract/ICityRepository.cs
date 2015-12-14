using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface ICityRepository
    {
        Task Add(City cityy);
        Task<City> Remove(string id);
        Task<List<City>> FindAll();
        Task<City> Find(string id);
        Task Update(string id, City city);
    }
}
