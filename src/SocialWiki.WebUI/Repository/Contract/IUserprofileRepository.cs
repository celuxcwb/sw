using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IUserprofileRepository
    {
        Task Add(UserProfile userprofile);
        Task<UserProfile> Remove(string id);
        Task<List<UserProfile>> FindAll();
        Task<UserProfile> Find(string id);
        Task Update(string id, UserProfile userprofile);
    }
}
