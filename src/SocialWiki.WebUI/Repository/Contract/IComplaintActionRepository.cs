using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IComplaintActionRepository
    {
        Task Add(ComplaintActionRepository complaintAction);
        Task<ComplaintActionRepository> Remove(string id);
        Task<List<ComplaintActionRepository>> FindAll();
        Task<ComplaintActionRepository> Find(string id);
        Task Update(string id, ComplaintActionRepository complaintAction);
    }
}
