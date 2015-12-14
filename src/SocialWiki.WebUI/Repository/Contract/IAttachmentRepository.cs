using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IAttachmentRepository
    {
        Task Add(Attachement attachment);
        Task<Attachement> Remove(string id);
        Task<List<Attachement>> FindAll();
        Task<Attachement> Find(string id);
        Task Update(string id, Attachement attachment);
    }
}
