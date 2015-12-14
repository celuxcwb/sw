using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IUserProfileInfoRepository
    {
        Task Add(UserProfileInfo userprofileinfo);
        Task<UserProfileInfo> Remove(string id);
        Task<List<UserProfileInfo>> FindAll();
        Task<UserProfileInfo> Find(string id);
        Task Update(string id, UserProfileInfo userprofileinfo);

    }
}
