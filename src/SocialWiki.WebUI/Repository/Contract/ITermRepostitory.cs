using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface ITermRepostitory
    {
        Task Add(Term term);
        Task<Term> Remove(string id);
        Task<List<Term>> FindAll();
        Task<Term> Find(string id);
        Task Update(string id, Term term);
    }
}
