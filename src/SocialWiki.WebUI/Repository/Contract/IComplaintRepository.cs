using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IComplaintRepository
    {
        Task Add(Complaint complaint);
        Task<Complaint> Remove(string id);
        Task<List<Complaint>> FindAll();
        Task<Complaint> Find(string id);
        Task Update(string id, Complaint complaint);
    }
}
