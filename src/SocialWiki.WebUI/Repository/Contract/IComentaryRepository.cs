using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;

namespace SocialWiki.WebUI.Repository.Contract
{
    public interface IComentaryRepository
    {
        Task Add(Comentary comentary);
        Task<Comentary> Remove(string id);
        Task<List<Comentary>> FindAll();
        Task<Comentary> Find(string id);
        Task Update(string id, Comentary comentary);

    }
}
