using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface ICategoryRepository
    {
        Task Add(Category category);
        Task<Category> Remove(string id);
        Task<List<Category>> FindAll();
        Task<Category> Find(string id);
        Task Update(string id, Category category);
    }
}

