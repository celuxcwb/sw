using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IComplaintFollowRepository
    {
        Task Add(ComplaintFollow complaintFollow);
        Task<ComplaintFollow> Remove(string id);
        Task<List<ComplaintFollow>> FindAll();
        Task<ComplaintFollow> Find(string id);
        Task Update(string id, ComplaintFollow complaintFolow);
    }
}
