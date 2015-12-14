using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface ITermAgreedRepository
    {
        Task Add(TermAgreed termAgreed);
        Task<TermAgreed> Remove(string id);
        Task<List<TermAgreed>> FindAll();
        Task<TermAgreed> Find(string id);
        Task Update(string id, TermAgreed category);
    }
}
